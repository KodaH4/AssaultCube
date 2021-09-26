using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AssaultCube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Process gameProc;
        public Int32 gamePID;
        public IntPtr hProc;
        public IntPtr baseAddress = IntPtr.Zero;
        public ProcessModule mainModule;
        public void attachGame()
        {
            Process[] processesByName = Process.GetProcessesByName("ac_client");
            if (processesByName.Length < 1)
            {
                MessageBox.Show("Game is not running!");
                return;
            }
            gameProc = processesByName[0];
            gamePID = gameProc.Id;
            hProc = functions.OpenProcess(0x1F0FFF, bInheritHandle: false, gameProc.Id);
            mainModule = gameProc.MainModule;
            baseAddress = mainModule.BaseAddress;
            MessageBox.Show("Connected");
            ammoButton.Enabled = true;
            ammoTxtBox.Enabled = true;
        }
        private void attachButton_Click(object sender, EventArgs e)
        {
            attachGame();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ammoButton.Enabled = false;
            ammoTxtBox.Enabled = false;
        }
        private void ammoButton_Click(object sender, EventArgs e)
        {
            setAmmo();
        }
        public void setAmmo()
        {
            IntPtr lpNumberOfBytesWritten; //need a blank variable to store output of writeprocessmemory

            byte[] memoryAddress = new byte[4]; //create a new byte with size depending on required bytes (normally 4 or 8)

            functions.ReadProcessMemory(hProc, (UIntPtr)((int)mainModule.BaseAddress + 0x0010F4F4), memoryAddress, 4L, IntPtr.Zero); //read processmemory to get memoryAddress

            uint ptr = BitConverter.ToUInt32(memoryAddress, 0); //convert bytes to uint32
            MessageBox.Show(ptr.ToString());
            functions.WriteProcessMemory(hProc, (IntPtr)ptr + 336, Convert.ToInt32(ammoTxtBox.Text), 4L, out lpNumberOfBytesWritten); //write to converted memoryAddress adding offset

            //Get 336 from 150 as HEX -> convert 150 hex to 336 decimal

            MessageBox.Show("Ammo Set!");
        }

        public void setAmmoMultiOffset()
        {
            //asdjifsdhkulsdflkhjdfslhjkfdglhjkudfgkjhldfgjkhfgdhjklfgdhljkdfghjlkdgfjkhgdf
            IntPtr lpNumberOfBytesWritten; //need a blank variable to store output of writeprocessmemory

            byte[] memoryAddress = new byte[4]; //create a new byte with size depending on required bytes (normally 4 or 8)

            functions.ReadProcessMemory(hProc, (UIntPtr)((int)mainModule.BaseAddress + 0x0010F418), memoryAddress, 4L, IntPtr.Zero); //read processmemory to get memoryAddress
            //
            //
            uint ptr = BitConverter.ToUInt32(memoryAddress, 0); //convert bytes to uint32 to get our pointer
            functions.ReadProcessMemory(hProc, (UIntPtr)((int)ptr + 24), memoryAddress, 4L, IntPtr.Zero); //read processmemory at this new address to get our next pointer

            ptr = BitConverter.ToUInt32(memoryAddress, 0); //store our new pointer in the old var


            functions.WriteProcessMemory(hProc, (IntPtr)ptr + 336, Convert.ToInt32(ammoTxtBox.Text), 4L, out lpNumberOfBytesWritten); //write to converted memoryAddress adding final offset

            //Get 336 from 150 as HEX -> convert 150 hex to 336 decimal

            MessageBox.Show("Ammo Set!");

        }

    }
}
