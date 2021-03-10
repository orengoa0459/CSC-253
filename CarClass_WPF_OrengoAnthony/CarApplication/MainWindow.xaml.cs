using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CarLibrary;
namespace CarApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Variables and Objects
        Car car = new Car();
        int speed = 0;
        int currentVehSpeed = 0;
        //This number is generated with the list and will be used as an identifier
        int vehNumber = 0;
        List<Car> carList = new List<Car>();
        #endregion

        #region Submit Button 
        private void submit_Button_Click(object sender, RoutedEventArgs e)
        {
            if(carYearBox.Text == "" || carMakeBox.Text == "" || carSpeedBox.Text == "")
            {
                //Clear text boxes if speed is an invalid number
                MessageBox.Show("Invalid Data! All boxes must be complete!");
                carMakeBox.Clear();
                carYearBox.Clear();
                carSpeedBox.Clear();
            }
            else if (int.TryParse(carSpeedBox.Text, out speed))
            {
                //Add car object to car list
                carList.Add(new Car() { Year = carYearBox.Text, Make = carMakeBox.Text, Speed = speed });
            }
            else
            {
                //Clear text boxes if speed is an invalid number
                MessageBox.Show("Invalid entry! Speed must be a number!");
                carMakeBox.Clear();
                carYearBox.Clear();
                carSpeedBox.Clear();
            }
            //Clear text boxes after car object is added to list
            carMakeBox.Clear();
            carYearBox.Clear();
            carSpeedBox.Clear();

        }
        #endregion

        #region Reset Vehicle Data Button
        private void resetData_Button_Click(object sender, RoutedEventArgs e)
        {
            //Clear text boxes after car object is added to list
            carMakeBox.Clear();
            carYearBox.Clear();
            carSpeedBox.Clear();
        }
        #endregion

        #region Display Button
        private void displayList_Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Display car list to user
            for (int i = 0; i < carList.Count; i++)
            {
                if (i < 1)
                {
                    vehicleDataLists.Items.Add("Vehicle Data\n**************************");
                }
                vehicleDataLists.Items.Add("Vehicle Number: " + (i + 1));
                vehicleDataLists.Items.Add($"Vehicle Year: {carList.ElementAt(i).Year}");
                vehicleDataLists.Items.Add($"Vehicle Make: {carList.ElementAt(i).Make}");
                vehicleDataLists.Items.Add($"Vehicle Max Speed: {carList.ElementAt(i).Speed}");
                vehicleDataLists.Items.Add("**************************");
            }
        }
        #endregion

        #region Clear List Button
        private void clearList_Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Clear car list 
            vehicleDataLists.Items.Clear();
        }
        #endregion

        #region Submit Vehicle Number Button
        private void submitVehNum_Button_Click(object sender, RoutedEventArgs e)
        {
            //Verify input is an int
            if(int.TryParse(VehicleNumBox.Text, out vehNumber))
            {
                if (vehNumber > carList.Count || vehNumber == 0)
                {
                    MessageBox.Show("Vehicle does not exist!");
                    VehicleNumBox.Clear();
                }
                else
                {
                    //VehicleNumBox.Clear();
                    currentVehSpeed = 0;
                    //Add vehicle start speed to box
                    vehicleSpeedBox.Text = $"{currentVehSpeed}";
                }               
            }
            else
            {
                //Display invalid entry to user
                MessageBox.Show("Invalid number! Try again!");
                VehicleNumBox.Clear();
            }          
        }
        #endregion

        #region Accelerate Button
        private void AccSpeed_Button_Click(object sender, RoutedEventArgs e)
        {
            //Increase vehicle speed by 5 until max speed is reached           
            if(vehNumber <= 0)
            {
                MessageBox.Show("Invalid! You must enter a vehicle number!");
            }
            else if (currentVehSpeed >= carList.ElementAt(vehNumber - 1).Speed)
            {
                MessageBox.Show("Max Speed Reached");
            }
            else
            {
                //Change text color when vehicle speed exceeds 105
                if (currentVehSpeed >= 105)
                {
                    vehicleSpeedBox.Foreground = Brushes.Red;
                    vehicleSpeedBox.Text = $"{currentVehSpeed += 5}";
                }
                else
                {
                    vehicleSpeedBox.Text = $"{currentVehSpeed += 5}";
                }
            }
        }  
        #endregion

        #region Decelerate Button
        private void decSpeed_Button_Click(object sender, RoutedEventArgs e)
        {
            if (vehNumber <= 0)
            {
                MessageBox.Show("Invalid! You must enter a vehicle number!");
                //Decrease vehicle speed by 5 until zero speed is reached
                vehicleSpeedBox.Clear();
            }            
            else if (currentVehSpeed == 0)
            {
                MessageBox.Show("Speed is zero");
            }
            else
            {
                if (currentVehSpeed >= 105)
                {
                    vehicleSpeedBox.Foreground = Brushes.Red;
                    vehicleSpeedBox.Text = $"{currentVehSpeed -= 5}";
                }
                else
                {
                    //Change text color back to white when vehicle speed is below 105
                    vehicleSpeedBox.Foreground = Brushes.White;
                    vehicleSpeedBox.Text = $"{currentVehSpeed -= 5}";
                }
            }
        }

        #endregion
        
    }
}
