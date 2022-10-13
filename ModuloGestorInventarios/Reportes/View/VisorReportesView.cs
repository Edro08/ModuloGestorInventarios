using System.Windows.Forms;

namespace ModuloGestorInventarios.Reportes.View
{
    public partial class VisorReportesView : Form
    {
        public VisorReportesView()
        {
            InitializeComponent();
  
        }

        private void VisorReportesView_Load(object sender, System.EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
