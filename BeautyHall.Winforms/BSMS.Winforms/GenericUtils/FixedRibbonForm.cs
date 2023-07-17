namespace BSMS.Winforms.GenericUtils
{
    public class FixedRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int SC_MAXIMIZE = 0xF030;
            const int SC_MINIMIZE = 0xF020;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE || command == SC_MAXIMIZE || command == SC_MINIMIZE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
    }
}
