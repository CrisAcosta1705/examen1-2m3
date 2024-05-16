namespace examen1
{
    public partial class Form1 : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly SalaryCalculator _salaryCalculator;
        public Form1()
        {
            InitializeComponent();
            _employeeRepository = new EmployeeRepository();
            _salaryCalculator = new SalaryCalculator();
        }


        private async void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Salary = decimal.Parse(txtSalary.Text)
            };
            await _employeeRepository.AddAsync(employee);
            await RefreshEmployeeListAsync();
        }
        private async Task RefreshEmployeeListAsync()
        {
            lstEmployees.Items.Clear();
            var employees = await _employeeRepository.GetAllAsync();
            foreach (var employee in employees)
            {
                lstEmployees.Items.Add($"{employee.Id}: {employee.Name} - {employee.Salary:C}");
            }
        }

        private async void btnCalculateTotalSalary_Click(object sender, EventArgs e)
        {
            var employees = await _employeeRepository.GetAllAsync();
            var totalSalary = _salaryCalculator.CalculateTotalSalary(employees);
            lblTotalSalary.Text = $"Salario Total: {totalSalary:C}";
        }

        private async void btnSaveToFile_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await _employeeRepository.SaveToFileAsync(saveFileDialog.FileName);
                }
            }
        }

        private async void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var xmlText = File.ReadAllText(openFileDialog.FileName); // Read the XML file as text
                    MessageBox.Show(xmlText, "XML Content"); // Display the XML content in a message box
                    await _employeeRepository.LoadFromFileAsync(openFileDialog.FileName);
                    await RefreshEmployeeListAsync();
                }
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lstEmployees.Items.Clear();
            lblTotalSalary.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}