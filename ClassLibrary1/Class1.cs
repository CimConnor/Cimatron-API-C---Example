using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interop.CimBaseAPI;
using System.Windows.Forms;
using System.Diagnostics;
using ApiShell;


namespace ClassLibrary1
{
    public class OpenWindowsForm : interop.CimBaseAPI.ICimCommand, interop.CimBaseAPI.ICreateCommand

    {

        // This property allows you to enable the command in Cimatron

        public int Enable()

        {

            return 1; // return true

        }

        // This property allows you to execute your own application created in Cimatron API Command.

        public void Execute()

        {
            ////Define an Cimatron Provider object
            interop.CimServicesAPI.CimApplicationProvider AppProvider = new interop.CimServicesAPI.CimApplicationProvider();
            //Get Application object from AppProvider object.
            interop.CimatronE.IApplication CimApp = (interop.CimatronE.IApplication)AppProvider.GetApplication();
            //interop.CimatronE.IPdm aPdm = CimApp.GetPdm();

            //interop.CimatronE.ICimDocument aDocument = CimApp.GetActiveDoc();
            //interop.CimMdlrAPI.IModelContainer aContainer = (interop.CimMdlrAPI.IModelContainer)aDocument;
            //interop.CimBaseAPI.IModel aTmpModel = (interop.CimBaseAPI.IModel)aContainer.Model;
            //interop.CimBaseAPI.ISetsFactory aSetFac = aTmpModel.GetSetsFactory();
            DM apiShellDm = new DM(CimApp);
            string ApiShellString =  apiShellDm.GetActvDocTitle();
            MessageBox.Show(ApiShellString);
             //aSetFac.CreateSet("Part", (interop.CimMdlrAPI.EFilterEnumType)0);

            


            //Debug.WriteLine("plz");

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            // your application code...

        }

        //This property allows you to set the Category Name of your own command.

        public string GetCategoryName()

        {

            return "GetDocString";

        }

        // This property allows you to set the Command Name of your own command.

        public string GetCommandName()

        {

            return "GetDocString";

        }

        // This property allows you to set the location of your own command in Cimatron menus.

        public string GetMenuPath()

        {

            return "test" + "\n" + "stes";

        }

        // This property allows you to set the string that will be shown in the status bar of Cimatron.

        public string GetPrompt()

        {

            return "Jasdf";

        }

        // This property allows you to set the Toolbar title of your own command.

        public string GetToolbarName()

        {

            return "My Toolbadsar";

        }

        // This property allows you to set the Tooltip for your own command.

        public string GetTooltip()

        {

            return "My Tooltipasdf";

        }

        // This property allows you to set the Description for your own command.

        public string GetDescription()

        {

            return "My Command is garbage";

        }

        // This property allows you to define the type of file that

        // you can use to view your own Commands.

        public int IsBelongToDoc(interop.CimBaseAPI.ECommandCategory iType)

        {

            // Check current file type, if PART then enable the command.

            return 1; // True

        }

        // This property allows you to Enable/Disable your own command in the Dropdown Menus.

        public int ShowInMenu()

        {

            return 1; // True

        }

        // This property allows you to Enable/Disable the command in the Toolbar.

        public int ShowInToolbar()

        {

            return 1; // True

        }

    }

}
