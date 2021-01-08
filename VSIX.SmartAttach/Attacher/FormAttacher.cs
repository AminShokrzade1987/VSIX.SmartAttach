using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvDTE;
using EnvDTE80;
using Geeks.VSIX.SmartAttach.Base;
using Geeks.VSIX.SmartAttach.Properties;
using GeeksAddin;
using System.IO;

namespace Geeks.VSIX.SmartAttach.Attacher
{
    public partial class FormAttacher : Form
    {
        static Dictionary<string, object> GlobalAddinCache = new Dictionary<string, object>();

        DTE2 DTE { get; set; }
        public FormAttacher(DTE2 dte)
        {
            InitializeComponent();
            DTE = dte;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            ReloadListOfRemoteMachines();
            ProcessListLoader.RunWorkerAsync();
        }

        void ReloadListOfRemoteMachines()
        {
            //lstRemoteMachines.Items.Clear();
            var machinesString = Settings.Default.RemoteMachines;
            if (!machinesString.HasValue())
                return;

            var machines = GetRemoteMachineNames(machinesString);
            //foreach (var m in machines)
            //    lstRemoteMachines.Items.Add(m);
        }

        Task flushTask;
        //void RefreshList()
        //{
        //    listBoxProcess.SafeAction(l => l.Items.Clear());

        //    var solutionName = Utils.GetSolutionName(DTE).ToLower();

        //    //var nominatedForSelection = -1;
        //    //var lengthOfLastNomination = 0;
        //    List<Process2> processes = new List<Process2>();
        //    List<ProcHolder> procHolders = new List<ProcHolder>();

        //    //int index = 0;
        //    using (var iis = new IIS())
        //    {
        //        processes = GetWorkerProcesses().OfType<EnvDTE80.Process2>().ToList();

        //        processes = RemoveInvalidProcesses(processes);

        //        if (CheckUser(processes) == false) return;

        //        if (flushTask != null) Task.WaitAll(flushTask);

        //        procHolders =
        //            processes
        //            .AsParallel()
        //            .Select(proc => ProcHolder.CheckAndAddProcHolder(proc))
        //            .Where(proc => proc != null)
        //            .OrderByDescending(proc => proc.StartTime)
        //            .ToList();

        //        flushTask = Task.Run(() => ProcHolder.ExcludedProcessesManager.Flush());

        //        foreach (ProcHolder holder in procHolders)
        //        {
        //            if ((checkBoxExcludeMSharp.Checked && holder.AppPool != null && !holder.AppPool.Contains("M#")) || (!checkBoxExcludeMSharp.Checked))
        //            {
        //                if (!ProcSession.ValidProcesses.Any(x => x.Process.ProcessID == holder.Process.ProcessID))
        //                    ProcSession.ValidProcesses.Add(holder);
        //                listBoxProcess.SafeAction(l => l.Items.Add(holder));
        //            }

        //            //if (solutionName.HasValue())
        //            //{
        //            //    var physicalPath = iis.GetPhysicalPath(holder.AppPool);
        //            //    if (physicalPath != null && physicalPath.ToLower().Contains(solutionName))
        //            //    {
        //            //        if (nominatedForSelection == -1)
        //            //        {
        //            //            nominatedForSelection = index;
        //            //            lengthOfLastNomination = holder.AppPool.Length;
        //            //        }
        //            //        else if (holder.AppPool.Length < lengthOfLastNomination)
        //            //        {
        //            //            nominatedForSelection = index;
        //            //            lengthOfLastNomination = holder.AppPool.Length;
        //            //        }
        //            //    }
        //            //}

        //            //index++;
        //        }

        //    }

        //    var count = listBoxProcess.SafeGet(() => listBoxProcess.Items.Count);
        //    if (count == 0)
        //        btnAttachToAll.SafeAction(b => b.Enabled = false);

        //    this.SafeAction(f => f.ActiveControl = listBoxProcess);
        //    //if (nominatedForSelection <= count - 1)
        //    //    listBoxProcess.SafeAction(l => l.SelectedIndex = nominatedForSelection);

        //    DTE.StatusBar.Text = "Ready.";
        //    lblStatus.SafeAction(statusBar, s => s.Text = "");

        //    ProcSession.InvalidProcesses.Clear();
        //    foreach (var InvalidProc in processes)
        //    {
        //        if (InvalidProc != null && !(procHolders.Any(x => x.Process.ProcessID == InvalidProc.ProcessID)))
        //        {
        //            ProcSession.InvalidProcesses.Add(InvalidProc);
        //        }
        //    }
        //}

        void RefreshList()
        {
            listBoxProcess.SafeAction(l => l.Items.Clear());

            List<Process2> processes = GetWorkerProcesses().OfType<EnvDTE80.Process2>().ToList();

            List<Process2> CatchedProcesses = new List<Process2>();
            if (ProcSession.ValidProcesses != null && ProcSession.ValidProcesses.Count > 0)
            {
                ProcSession.ValidProcesses.ForEach(x => { var Prox = processes.Where(y => y.ProcessID == x.Process.ProcessID).FirstOrDefault(); if (Prox != null) CatchedProcesses.Add(Prox); });
                if (CatchedProcesses != null && CatchedProcesses.Count > 0)
                {
                    AddProcessToListShow(CatchedProcesses);
                }
            }

            var count = listBoxProcess.SafeGet(() => listBoxProcess.Items.Count);
            if (count == 0)
                btnAttachToAll.SafeAction(b => b.Enabled = false);

            AddProcessToListShow(processes);


            count = listBoxProcess.SafeGet(() => listBoxProcess.Items.Count);
            if (count == 0)
                btnAttachToAll.SafeAction(b => b.Enabled = false);

            this.SafeAction(f => f.ActiveControl = listBoxProcess);
            DTE.StatusBar.Text = "Ready.";
            lblStatus.SafeAction(statusBar, s => s.Text = "");

            ProcSession.ValidProcesses.Clear();
            if (listBoxProcess.Items != null && listBoxProcess.Items.Count > 0)
            {
                foreach (var Item in listBoxProcess.Items)
                {
                    ProcSession.ValidProcesses.Add(((ProcHolder)(Item)));
                }
            }

            ProcSession.InvalidProcesses.Clear();

            //foreach (var InvalidProc in processes)
            //{
            //    if (InvalidProc != null && !(procHolders.Any(x => x.Process.ProcessID == InvalidProc.ProcessID)))
            //    {
            //        ProcSession.InvalidProcesses.Add(InvalidProc);
            //    }
            //}
        }

        private void AddProcessToListShow(List<Process2> processes)
        {
            using (var iis = new IIS())
            {
                if (CheckUser(processes) == false) return;

                var procHolders =
                    processes
                    .AsParallel()
                    .Select(proc => ProcHolder.CheckAndAddProcHolder(proc))
                    .Where(proc => proc != null)
                    .OrderByDescending(proc => proc.StartTime)
                    .ToList();

                foreach (ProcHolder holder in procHolders)
                {
                    if ((checkBoxExcludeMSharp.Checked && holder.AppPool != null && !holder.AppPool.Contains("M#")) || (!checkBoxExcludeMSharp.Checked))
                    {
                        bool AlreadyExists = false;
                        if (listBoxProcess.Items != null && listBoxProcess.Items.Count > 0)
                        {
                            foreach (var Item in listBoxProcess.Items)
                            {
                                if (((ProcHolder)(Item)).Process.ProcessID == holder.Process.ProcessID)
                                {
                                    AlreadyExists = true;
                                    break;
                                }
                            }
                        }
                        if (!AlreadyExists)
                            listBoxProcess.SafeAction(l => l.Items.Add(holder));
                    }
                }
            }
        }

        private List<Process2> RemoveInvalidProcesses(List<Process2> AllProcesses)
        {
            List<Process2> Result = new List<Process2>();
            AllProcesses.ForEach(x => { if (!ProcSession.InvalidProcesses.Any(y => y.ProcessID == x.ProcessID)) Result.Add(x); });
            return Result;
        }

        public void UpdateInvalidProcesses(List<Process2> AllProcesses)
        {

        }


        private bool IsStillValid()
        {
            bool Result = true;

            return Result;
        }

        bool CheckUser(List<Process2> processes)
        {
            var w3wpProcess = processes.FirstOrDefault(x => x.Name.Contains(ExcludedProcessesManager.WebServer_W3WP_ProcessName));
            if (w3wpProcess != null)
            {
                var process = System.Diagnostics.Process.GetProcessById(w3wpProcess.ProcessID);
                try
                {
                    var startDateTime = process.StartTime;
                }
                catch (System.ComponentModel.Win32Exception ex) when (ex.HResult == -2147467259)
                {
                    this.SafeAction(l => MessageBox.Show("You should run Visual studio under administrator user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    this.SafeAction(l => l.Close());
                    return false;
                }
            }

            return true;
        }

        IEnumerable<EnvDTE.Process> GetWorkerProcesses()
        {
            lblStatus.SafeAction(statusBar, s => s.Text = "Loading Local processes...");

            foreach (EnvDTE.Process p in DTE.Debugger.LocalProcesses)
                yield return p;

            var machinesString = Settings.Default.RemoteMachines;
            if (machinesString.HasValue())
            {
                var debuggerTwo = DTE.Debugger as EnvDTE80.Debugger2;
                var transport = debuggerTwo.Transports.Item("Default");

                var machines = GetRemoteMachineNames(machinesString);
                foreach (var machine in machines)
                {
                    lblStatus.SafeAction(statusBar, s => s.Text = "Loading {0} processes...".FormatWith(machine));
                    var cacheKey = "W3WP" + machine;

                    Processes processes = null;
                    try
                    {
                        if (GlobalAddinCache.ContainsKey(cacheKey))
                        {
                            processes = GlobalAddinCache[cacheKey] as Processes;
                        }
                        else
                        {
                            processes = debuggerTwo.GetProcesses(transport, machine);
                            GlobalAddinCache[cacheKey] = processes;
                        }
                    }
                    catch (Exception err)
                    {
                        DTE.StatusBar.Text = err.Message;
                        lblStatus.SafeAction(statusBar, s => s.Text = err.Message);
                    }

                    if (processes != null)
                    {
                        foreach (EnvDTE.Process p in processes)
                            yield return p;

                    }
                }
            }
        }




        static IOrderedEnumerable<string> GetRemoteMachineNames(string machinesString)
        {
            return machinesString.Split('|').Where(m => m.HasValue()).Select(m => m.ToUpper()).Distinct().OrderBy(m => m);
        }

        void btnAttach_Click(object sender, EventArgs e) => AttachToSelected();

        void AttachToSelected()
        {
            DisableAllButtons();
            foreach (ProcHolder holder in listBoxProcess.SelectedItems)
                if (holder.Process != null)
                    holder.Process.Attach();
            Close();
        }

        void KillSelected()
        {
            foreach (ProcHolder holder in listBoxProcess.SelectedItems)
            {
                if (holder.Process != null)
                {
                    try
                    {
                        var prc = System.Diagnostics.Process.GetProcessById(holder.Process.ProcessID);
                        if (prc != null)
                        {
                            prc.Kill();
                        }
                        else
                        {
                            MessageBox.Show("Cannot find process with id " + holder.Process.ProcessID, "Error (on FormAttacher.cs line 191)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception err)
                    {
                        ErrorNotification.EmailError(err);
                    }
                }
            }

            System.Threading.Thread.Sleep(100);
            RefreshList();
        }

        void listBoxProcess_MouseDoubleClick(object sender, MouseEventArgs e) => AttachToSelected();

        void listBoxProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAttach.Enabled = listBoxProcess.SelectedItem != null;
        }

        void btnAttachToAll_Click(object sender, EventArgs e)
        {
            DisableAllButtons();
            foreach (ProcHolder holder in listBoxProcess.Items)
                if (holder.Process != null)
                {
                    holder.Process.Attach();
                }

            Close();
        }

        void btnOriginal_Click(object sender, EventArgs e)
        {
            Close();
            DTE.ExecuteCommand("Debug.AttachtoProcess", "");
        }

        void DisableAllButtons()
        {
            btnAttach.Enabled = false;
            btnAttachToAll.Enabled = false;
        }

        void FormAttacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) Close();
            if (e.KeyData == Keys.F5) RefreshList();
        }

        void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearCache();
            RefreshList();
        }

        void ClearCache()
        {
            for (int i = GlobalAddinCache.Keys.Count - 1; i >= 0; i--)
            {
                var key = GlobalAddinCache.Keys.ElementAt(i);
                if (key.StartsWith("W3WP"))
                {
                    GlobalAddinCache.Remove(key);
                }
            }
        }

        void DeleteCurrentRemoteMachine()
        {
            //if (lstRemoteMachines.SelectedIndex >= 0)
            //{
            //    lstRemoteMachines.Items.RemoveAt(lstRemoteMachines.SelectedIndex);

            //    Settings.Default.RemoteMachines = "";
            //    foreach (var m in lstRemoteMachines.Items)
            //        Settings.Default.RemoteMachines += m + "|";
            //    Settings.Default.Save();

            //    ReloadListOfRemoteMachines();
            //}
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            ////if (txtMachineName.Text.HasValue())
            //{
            //    Settings.Default.RemoteMachines += "|" + txtMachineName.Text;
            //    Settings.Default.Save();
            //    ReloadListOfRemoteMachines();
            //}
        }

        void ProcessListLoader_DoWork(object sender, DoWorkEventArgs e) => RefreshList();

        void FilterItemsWithSearchTerm()
        {
            var searchTerm = txtSearchProcess.Text.ToLower();

            if (string.IsNullOrEmpty(searchTerm)) { RefreshList(); return; }

            for (int i = listBoxProcess.Items.Count - 1; i >= 0; i--)
            {
                var currentItem = listBoxProcess.Items[i].ToString().ToLower();
                if (currentItem.Contains(searchTerm)) continue;
                listBoxProcess.SafeAction(l => l.Items.RemoveAt(i));
            }
        }

        void txtSearchProcess_TextChanged(object sender, EventArgs e) => FilterItemsWithSearchTerm();

        void listBoxProcess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Delete) return;

            //if (tabControl.SelectedTab == tbpgWorkers) KillSelected();
            //if (tabControl.SelectedTab == tbpgRemoteMachines) DeleteCurrentRemoteMachine();
        }

        void checkBoxExcludeMSharp_CheckedChanged(object sender, EventArgs e) => RefreshList();
    }
}