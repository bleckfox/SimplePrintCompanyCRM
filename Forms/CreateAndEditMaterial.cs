using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCatalog.Models;
using AppContext = DatabaseCatalog.ApplicationContext;

namespace Forms
{
    public partial class CreateAndEditMaterial : Form
    {
        private int _id;
        private Material _materialToUpdate;

        public CreateAndEditMaterial()
        {
            InitializeComponent();
        }

        public CreateAndEditMaterial(string? id)
        {
            InitializeComponent();
            if (id != null)
                int.TryParse(id, out _id);
        }

        private void WindowLoad(object sender, EventArgs e)
        {
            using (AppContext context = new AppContext())
            {
                Material? material = context.Materials.FirstOrDefault(x => x.Id == _id);

                if (material != null)
                {
                    _materialToUpdate = material;
                    nameTextBox.Text = material.Name;
                    typeTextBox.Text = material.Type;
                    sizeTextBox.Text = material.PaperSettings;
                    datePicker.Value = material.Date;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string type = typeTextBox.Text;
            string settings = sizeTextBox.Text;
            DateTime date = datePicker.Value;

            using (AppContext context = new AppContext())
            {
                if (_materialToUpdate == null)
                {
                    Material material = new Material()
                    {
                        Name = name,
                        Type = type,
                        PaperSettings = settings,
                        Date = date
                    };

                    context.Materials.Add(material);
                }
                else
                {
                    _materialToUpdate.Name = name;
                    _materialToUpdate.Type = type;
                    _materialToUpdate.PaperSettings = settings;
                    _materialToUpdate.Date = date;

                    context.Materials.Update(_materialToUpdate);
                }

                context.SaveChanges();
            }

            this.Close();
        }
    }
}
