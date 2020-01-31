using Main_Module;
using System;
using System.Threading;
using System.Windows.Forms;

static class Program
{
    private static Main_Module.SplashScreen splashScreen = null;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        //show splash
        Thread splashThread = new Thread(new ThreadStart(
            delegate
            {
                splashScreen = new Main_Module.SplashScreen();
                Application.Run(splashScreen);
            }
            ));

        splashThread.SetApartmentState(ApartmentState.STA);
        splashThread.Start();

        //run form - time taking operation
        MainForm mainForm = new MainForm();
        mainForm.Load += new EventHandler(mainForm_Load);
        Application.Run(mainForm);
    }

    static void mainForm_Load(object sender, EventArgs e)
    {
        //close splash
        if (splashScreen == null)
        {
            return;
        }

        splashScreen.Invoke(new Action(splashScreen.Close));
        splashScreen.Dispose();
        splashScreen = null;
    }
}
