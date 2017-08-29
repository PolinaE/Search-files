using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using FastTreeNS;


namespace searchFiles
{
    public partial class Form1 : Form
    {
        DateTime date = DateTime.Now;
        int count;
        Thread thread;
        ManualResetEvent MRE;
        bool end=false;
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void AddMessageDelegate(string message);
        
        public void FileNameOut(string message)
        {
            fileName_Label.Text = message; 
        }
        public void CountFilesOut(string message)
        {
            countFiles_Label.Text = message; 
        }
        private void choosePath_Button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                path_textBox.Text = folderBrowserDialog1.SelectedPath;
        }
        private void startSearch_Button_Click(object sender, EventArgs e)
        {
            startSearch_Button.Enabled = false;
            count = 0;
            try
            {              
                string fileMask = Convert.ToString(mask_textBox.Text);
                if (fileMask != "" && path_textBox.Text != "" && fileMask.IndexOf('.') != -1)  
                {
                    string contText = Convert.ToString(contains_textBox.Text);
                    DirectoryInfo dir = new DirectoryInfo(path_textBox.Text);
                    string dirStr= Convert.ToString(path_textBox.Text);
                    Node root = new Node { FullPath = dirStr };
                    thread = new Thread(() => buildTree(root, fileMask, contText)) { IsBackground = true };
                    MRE = new ManualResetEvent(true);
                    thread.Start();
                    
                    FastTree ft = new FastTree() { Dock = DockStyle.Fill, ShowIcons = true, ShowRootNode = true };
                    ftLocation.Visible = true;
                    ft.Parent = ftLocation;
                    ft.NodeIconNeeded += ft_NodeIconNeeded;

                    timer1.Start();

                    Application.Idle += delegate
                      {
                          if (thread.IsAlive)
                              ft.Build(root);
                          else
                              if (!end)
                              {
                                  timer1.Stop();
                                  MessageBox.Show("Поиск завершен", Convert.ToString(thread.ThreadState), MessageBoxButtons.OK);
                                  end = true;
                              }
                      };
                }
                else MessageBox.Show("Ошибка ввода стартовой директории или маски файла","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
            }
            catch (OutOfMemoryException ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
            }
        }
        private void pause_Button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MRE.Reset();
        }
        private void continue_Button_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MRE.Set();
        }
        private void break_Button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            thread.Abort();
        }
        void ft_NodeIconNeeded(object sender, ImageNodeEventArgs e)
        {
            if (!(e.Node as Node).IsFile)
                e.Result = Properties.Resources.folder;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();
            stopWatch = stopWatch.AddTicks(tick);
            time_Label.Text = String.Format("{0:HH:mm:ss:ff}", stopWatch);
        }
        private void buildTree(Node root, string fileMask, string contText)
        {
            var toProcess = new Stack<Node>();
            toProcess.Push(root);
            while(toProcess.Count>0)
            {
                var node = toProcess.Pop();
                try
                {
                    foreach (var dir in Directory.GetDirectories(node.FullPath))
                    {
                        var n = new Node { FullPath = dir };
                        node.Add(n);
                        toProcess.Push(n);
                    }
                    foreach (var fileP in Directory.GetFiles(node.FullPath, fileMask))
                    {
                        if (MRE.WaitOne())
                        {
                            FileInfo file = new FileInfo(fileP);
                            var n = new Node { FullPath = fileP, IsFile = true };
                            Invoke(new AddMessageDelegate(FileNameOut), new object[] { file.Name });
                            if (contText != "")
                            {
                                if (File.ReadAllText(file.FullName).Contains(contText))
                                    node.Add(n);
                            }
                            else
                                node.Add(n);
                            count++;
                            Invoke(new AddMessageDelegate(CountFilesOut), new object[] { Convert.ToString(count) });
                        }
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Node : IEnumerable<Node>
    {
        private List<Node> nodes;
        public bool IsFile { get; set; }
        public string FullPath { get; set; }
        public string Name { get { return Path.GetFileName(FullPath); } }
        public bool HasFile
        {
            get
            {
                return IsFile || nodes.Any(n => n.HasFile);
            }
        }
        public Node()
        {
            nodes = new List<Node>();
        }
        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? FullPath : Name;
        }
        public void Add(Node node)
        {
            nodes.Add(node);
        }
        IEnumerable<Node> Nodes
        {
            get
            {
                for (int i = 0; i < nodes.Count; i++)
                    yield return nodes[i];
            }
        }
        public IEnumerator<Node> GetEnumerator()
        {
            return Nodes.Where(n => n.HasFile).GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}