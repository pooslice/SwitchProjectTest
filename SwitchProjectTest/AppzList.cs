namespace SwitchProjectTest
{
    class AppzList
    {
        //all github appz in a 2d array
        //will replace with a list when i have time
        //and implement importing own application-list
        //for now i will have these hard coded
        private static string[,] homebrew = new string[12, 3] {
                                 // copy this        { "owner", "reponame", "Descripton"},
                                                     { "Atmosphere-NX", "Atmosphere", "Atmosphère is a work-in-progress customized firmware."},
                                                     { "CTCaer", "hekate", "Custom Graphical Nintendo Switch bootloader, firmware patcher, tools, and many more."},
                                                     { "WerWolv", "Tesla-Menu", "Provides an overlay menu."},
                                                     { "Huntereb", "Awoo-Installer", "A No-Bullshit NSP, NSZ, XCI, and XCZ Installer."},
                                                     { "HamletDuFromage", "aio-switch-updater", "A Nintendo Switch homebrew app to download and update CFWs, sigpatches, FWs and cheat codes."},
                                                     { "J-D-K", "JKSV", "Data Dump/Restore tool (Save manager)"},
                                                     { "XorTroll", "Goldleaf", "Goldleaf is multipurpose homebrew tool"},
                                                     { "16BitWonder", "NX-Update-Checker", "A small console application that checks a Switch's installed contents against a provided versionlist for newer/missing updates/DLC"},
                                                     { "StarDustCFW", "StarDust-Toolkit", "No Descripton"},
                                                     { "FlagBrew", "Checkpoint", "A fast and simple homebrew save manager for 3DS and Switch written in C++"},
                                                     { "exelix11", "SwitchThemeInjector", "An homebrew app that runs on the switch itself and can be used to install and manage themes"},
                                                     { "mtheall", "ftpd", "FTP Server for 3DS/Switch/Linux"}
        };

        public string[,] GetAppzList()
        {
            return homebrew;
        }
    }
}
