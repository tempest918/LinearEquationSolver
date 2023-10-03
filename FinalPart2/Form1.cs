using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // Set filter for text or all files
                Filter = "Text Files|*.txt|All Files|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                try
                {
                    // Read coefficients from the selected text file
                    string[] lines = File.ReadAllLines(fileName);

                    // Make sure file has 2 lines
                    if (lines.Length >= 2)
                    {
                        // TryParse coefficients from string to pass back to TextBoxes
                        if (TryParseCoefficientsFromString(lines[0], out double a1, out double b1, out double c1) &&
                            TryParseCoefficientsFromString(lines[1], out double a2, out double b2, out double c2))
                        {
                            CoeffA1TextBox.Text = a1.ToString();
                            CoeffB1TextBox.Text = b1.ToString();
                            CoeffC1TextBox.Text = c1.ToString();
                            CoeffA2TextBox.Text = a2.ToString();
                            CoeffB2TextBox.Text = b2.ToString();
                            CoeffC2TextBox.Text = c2.ToString();

                            ResultLabel.ForeColor = Color.Green;
                            ResultLabel.Text = $"Imported coefficients from file {fileName}.";

                        }
                        else
                        {
                            // Let user know data in file is invalid
                            ResultLabel.ForeColor = Color.Red;
                            ResultLabel.Text = "Invalid data format in the file.";
                        }
                    }
                    else
                    {
                        // Let user know file must have at least 2 lines
                        ResultLabel.ForeColor = Color.Red;
                        ResultLabel.Text = "The file must contain at least two lines of coefficients.";
                    }
                }
                catch (IOException)
                {
                    // Catch error if file can't be read for some reason
                    ResultLabel.ForeColor = Color.Red;
                    ResultLabel.Text = "Error reading the file.";
                }
            }
        }

        private bool TryParseCoefficients(out double a1, out double b1, out double c1, out double a2, out double b2, out double c2)
        {
            // Initialize parameters
            a1 = b1 = c1 = a2 = b2 = c2 = 0.0;

            // Try parsing all of the values in the text boxes, returning the parsed values for each coefficient and a boolean value to show success/failure 
            if (double.TryParse(CoeffA1TextBox.Text, out a1) &&
                double.TryParse(CoeffB1TextBox.Text, out b1) &&
                double.TryParse(CoeffC1TextBox.Text, out c1) &&
                double.TryParse(CoeffA2TextBox.Text, out a2) &&
                double.TryParse(CoeffB2TextBox.Text, out b2) &&
                double.TryParse(CoeffC2TextBox.Text, out c2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool TryParseCoefficientsFromString(string line, out double a, out double b, out double c)
        {
            // Initialize parameters
            a = b = c = 0.0; 

            // Split the input line by both commas and spaces
            string[] delimiters = { ",", " " };
            string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 3)
            {
                // Try to parse the coefficients from the split parts
                if (double.TryParse(parts[0], out a) &&
                    double.TryParse(parts[1], out b) &&
                    double.TryParse(parts[2], out c))
                {
                    return true;
                }
            }

            return false;
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            // Parse coefficients from text boxes
            if (TryParseCoefficients(out double a1, out double b1, out double c1, out double a2, out double b2, out double c2))
            {
                // Check if the lines are parallel or identical
                if (a1 * b2 == a2 * b1 && b1 * c2 == b2 * c1)
                {
                    ResultLabel.ForeColor = Color.Black;
                    ResultLabel.Text = "The two lines are identical.";
                }
                else if (a1 * b2 == a2 * b1)
                {
                    ResultLabel.ForeColor = Color.Black;
                    ResultLabel.Text = "The two lines are parallel and do not intersect.";
                }
                else
                {
                    // Calculate the intersection point
                    double x = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
                    double y = (c1 * a2 - c2 * a1) / (b1 * a2 - b2 * a1);
                    ResultLabel.ForeColor = Color.Green;
                    ResultLabel.Text = $"The intersection point is at ({x}, {y}).";
                }
            }
            else
            {
                ResultLabel.ForeColor = Color.Red;
                ResultLabel.Text = "Invalid input. Please enter valid coefficients.";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CoeffA1TextBox.Text = CoeffB1TextBox.Text = CoeffC1TextBox.Text = string.Empty;
            CoeffA2TextBox.Text = CoeffB2TextBox.Text = CoeffC2TextBox.Text = string.Empty;
            ResultLabel.ForeColor = Color.Black;
            ResultLabel.Text = string.Empty;
        }
    }
}
