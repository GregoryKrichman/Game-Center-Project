using gameCenter.Projects;
using gameCenter.Projects.Calculator;
using gameCenter.Projects.CurrencyConverter;
using gameCenter.Projects.Snake;
using gameCenter.Projects.Tetris;
using gameCenter.Projects.TicTacToe;
using gameCenter.Projects.TodoList;
using gameCenter.Projects.UserManegment;
using GameCenter.Projects.CarGame;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace gameCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer clock = new()
            {
                Interval =TimeSpan.FromSeconds(1)
            };

            clock.Tick += ShowCurrentDate!;
            clock.Start();
        }




        private void ShowCurrentDate(object sender, EventArgs e)
        {
            DateLabel.Content = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm:ss");
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image image = (sender as Image)!;
            image.Opacity = 0.6;
            GameText.Content = (image.Name) switch
            {
                "Image1" => "User Management System",
                "Image2" => "To do list",
                "Image3" => "Currency Convertor",
                "Image4" => "Car Game",
                "Image5" => "Tic Tac Toe",
                "Image6" => "Calculator",
                "Image7" => "Snake Game",
                "Image8" => "Tetris Game",
                "UserAvatar" => "Developer Information",

                _ => "please pick from the apps below"
            };
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Image)!.Opacity = 1;
            GameText.Content = "please pick from the apps below";
        }

        private void Image1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //Project1 project1 = new();
            //Hide();
            //project1.ShowDialog();
            //Show();

            UserManegment UserManegmentProject = new();
            ProjectPresentationPage presentetion = new();
            presentetion.OnStart(
               "Users Managment System", "" +
                "- This is a User Management Program.\n" +
        "- Technologies used in this project: C# based on WPF Interface, .NET.\n\n" +
        "- This program will assist you in managing all the users on your website.\n" +
        "- You can perform CRUD operations such as add/delete/edit and update for all your users' names and email addresses.\n" +
        "- You can also sign in/out your users.\n" +
        "- Additionally, you can choose to freeze up/down any of the users.\n\n" +
        "- To start the program, click on the image on the left.\n" +
        "- To return to the Home Page, please click the user's avatar on the left side at the header above.",


            Image1.Source,
                UserManegmentProject
            );
            presentetion.ShowDialog();
        }

        private void Image2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //TodoList todoListProject = new();
            //Hide();
            //todoListProject.ShowDialog();
            //Show();
            TodoList project2 = new();
            ProjectPresentationPage presentetion = new();
            presentetion.OnStart(
                "Welcome to the To-Do List Application",
        "Explore the features of this To-Do List project, crafted with C# and WPF on the .NET platform.\n\n" +
        "Key Features:\n" +
        "- Efficiently manage your schedule by consolidating all tasks in one place.\n" +
        "- Edit, delete, add, or mark tasks as complete with ease.\n" +
        "- View the creation date for each mission to stay organized.\n" +
        "- Double-click on a task to edit or delete it.\n" +
        "- Create a new task by double-clicking on 'Enter a new task' TextBox and clicking the 'Plus' button.\n\n" +
        "Getting Started:\n" +
        "- Click on the left image to launch the program.\n" +
        "- Return to the Home Page by clicking the user's avatar in the header above.",
                Image2.Source,
                project2
            );
            presentetion.ShowDialog();
        }

        private void Image3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //CurrencyConverterView currencyProject = new();
            //Hide();
            //currencyProject.ShowDialog();
            //Show();
            CurrencyConverterView project3 = new();
            ProjectPresentationPage presentetion = new();
            presentetion.OnStart(
                "Currency Converter Application",
        "Experience the Currency Converter project, crafted with C# using WPF, .NET, HttpClient, Dictionary, JsonSerializer, Async, and API integration.\n\n" +
        "Key Features:\n" +
        "- View the current value of currencies on any given day.\n" +
        "- Real-time updates: The program communicates with a currency API to provide the latest exchange rates daily.\n" +
        "- Convert any amount by selecting the source and target currencies and clicking the 'Convert' button.\n" +
        "- Important: Ensure you enter the API key as per the instructions provided in the project's GitHub repository; the key is encoded for security.\n\n" +
        "Getting Started:\n" +
        "- Launch the program by clicking the image on the left.\n" +
        "- Return to the Home Page by clicking the user's avatar in the header on the left.",
                Image3.Source,
                project3
            );
            presentetion.ShowDialog();

        }
        private void Image4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CarGame project4 = new();
            ProjectPresentationPage presentation = new();
            presentation.OnStart(
                "Highway Racer - Car Game",
                "Embark on a thrilling racing adventure in this high-octane game, where your skills will be put to the test on a perilous highway filled with explosive obstacles.\n\n" +
                "Key Features:\n" +
                "- Technologies used: C# with WPF Interface, .Net, Dispatcher Time, and the Controls Library.\n" +
                "- Navigate through the hazardous highway, evading bombs to achieve the highest score possible.\n" +
                "- Each successfully avoided bomb adds to your score, so hone your maneuvering skills.\n" +
                "- Use the right and left keys on your keyboard to control the car's movement.\n" +
                "- The game ends upon collision with a bomb, resetting your score.\n\n" +
                "Getting Started:\n" +
                "- Launch the game by clicking on the Car Image on the left.\n" +
                "- Return to the Home Page by clicking the user's avatar in the header on the left.",
                Image4.Source,
                project4
            );
            presentation.ShowDialog();
        }




        private void Image5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TicTacToe project5 = new();
            ProjectPresentationPage presentation = new();
            presentation.OnStart(
                "Classic Tic Tac Toe Game",
                "Experience the timeless fun of Tic Tac Toe in this classic game, developed with C# using WPF Interface, .Net, UIElement Class, and Task.Delay.\n\n" +
                "Key Features:\n" +
                "- Challenge the computer to a strategic game of Tic Tac Toe.\n" +
                "- Begin the game by clicking one of the buttons on the panel, starting with 'X'.\n" +
                "- The first player to achieve 3 buttons in a row, column, or diagonal wins.\n" +
                "- Each win contributes to the player and computer scores.\n\n" +
                "Getting Started:\n" +
                "- Launch the game by clicking on the Tic Tac Toe Image on the left.\n" +
                "- Return to the Home Page by clicking the user's avatar in the header on the left.",
                Image5.Source,
                project5
            );
            presentation.ShowDialog();
        }



        private void Image6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Calculator project6 = new();
            ProjectPresentationPage presentation = new();
            presentation.OnStart(
                "Smart Calculator",
                "Explore the capabilities of this advanced Calculator Project developed with C# using WPF Interface, .NET, and the Math library.\n\n" +
                "Key Features:\n" +
                "- Perform a wide range of calculations, including addition, subtraction, multiplication, and more.\n" +
                "- Conveniently reset the calculator by clicking the red button (C) if needed during your calculation.\n" +
                "- Ensure accuracy by clicking the equal button at the end of your process to see the result.\n\n" +
                "Getting Started:\n" +
                "- Launch the calculator by clicking on the Calculator Image on the left.\n" +
                "- Return to the Home Page by clicking the user's avatar in the header on the left.",
                Image6.Source,
                project6
            );
            presentation.ShowDialog();
        }


        private void Image7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SnakeGame project7 = new();
            ProjectPresentationPage presentation = new();
            presentation.OnStart(
                "Classic Snake Game",
                "Embark on a nostalgic journey with this Classic Snake Game, developed using C# with WPF Interface, .NET, Enum, IEnumerable, Dictionary, LinkedList, Task Delay, Transform Class, and Key Control Library.\n\n" +
                "Key Features:\n" +
                "- Eat the food strategically placed on the grid to grow your snake and achieve the highest score.\n" +
                "- Start the game by pressing any key, and face a countdown from 3 before the action begins.\n" +
                "- Direct the snake using the right, left, down, and up keys on your keyboard.\n" +
                "- Be cautious and avoid hitting the window's sides or the snake itself to stay alive.\n" +
                "- Each time you eat, the snake grows longer, increasing the challenge.\n" +
                "- Restart the game by pressing any key if you meet an unfortunate end.\n\n" +
                "Getting Started:\n" +
                "- Launch the game by clicking on the Snake Image on the left.\n" +
                "- Return to the Home Page by clicking the user's avatar in the header on the left.",
                Image7.Source,
                project7
            );
            presentation.ShowDialog();
        }



        private void Image8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Tetris project8 = new();
            ProjectPresentationPage presentation = new();
            presentation.OnStart(
                "Classic Tetris Game",
                "Experience the timeless challenge of Tetris in this classic game, developed with C# using WPF Interface, .NET, IEnumerable, Dispatcher Time, Math Class, Task Delay, BitMapImage, Canvas, and Key Control Library.\n\n" +
                "Key Features:\n" +
                "- Use the arrow keys to move and rotate the Tetrimino, fitting it into the desired location.\n" +
                "- Start the game by pressing any key, initiating a countdown from 3.\n" +
                "- Complete horizontal lines with no gaps to earn points and make them disappear.\n" +
                "- Strive for the highest score by skillfully placing Tetriminos as the game progresses.\n" +
                "- The challenge increases as Tetriminos fall faster over time.\n" +
                "- The game ends when a Tetrimino reaches the top of the playfield; restart by pressing any key.\n\n" +
                "Getting Started:\n" +
                "- Launch the game by clicking on the Tetris Image on the left.\n" +
                "- Return to the Home Page by clicking the user's avatar in the header on the left.",
                Image8.Source,
                project8
            );
            presentation.ShowDialog();
        }



        private void Avatar_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Name: Gregory Krichman\nEmail: g_gregory@walla.co.il\nPhone: 054-6435470");
        }


    }
}
