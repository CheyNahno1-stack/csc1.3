namespace ExpenseTracker
{
    public partial class xpenseTrcker : Form
    {
        public class Expense
        {
            public decimal Amount { get; }
            //to declare my variable amount of expense
            //the get; means the get will come from this local to this class
            public string Description { get; }
            // saying the description will be a string 
            public DateTime Date { get; }
            //this will store the date and time Date Time is already embedded in 


            public Expense(decimal amount, string description, DateTime date)
            //Constructor for the expense class, the above listed properties as parameters 
            {
                Amount = amount;// amount paramter will be assigned value from Amount clas when its called later
                Description = description;
                //same with description this will now be associated with decriptor class
                Date = date;
                //date paramters=date property 
            }

        }

        private List<Expense> expenses = new List<Expense>();
        //this is where i declare my list and where i store all my expenses
        private decimal totalExpenses = 0;
        //declared this variable and make sure it tracks total expense
        //decimal will show im using decimal value the totalexpense is the variable
        //=0 is the initialization and will start on zero
        public xpenseTrcker()
        {
            InitializeComponent();//makes sure it loads properly

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSumit_Click(object sender, EventArgs e)
        //creating a method for Add Expense that i will connect to button later 
        {
            MessageBox.Show("Button Clicked.");
            try
            //this is because this section of my code may have exceptions we need to confirgure 
            {
                if (!decimal.TryParse(txtExpenseCost.Text, out decimal amount) || amount <= 0)
                //using if statement with the decimal for precision, try parse is either true or false
                //this will convert whatever is entered into the text expense cost and if it is true it will run 
                //the amount <=0 makes sure only positive number
                {
                    throw new FormatException("Invalid amount. Please enter a positive number.");
                    //this will pop up if the message box is invalid or True 
                }
                string description = txtExpenseName.Text.Trim();
                //anything that goes into the text box expense name will 
                //be assigned to the description variable 
                //trim takes out any extra whitespace making it cleaner to look at

                if (string.IsNullOrWhiteSpace(description))
                //this is an exception that will stop running the code if 
                //there isnt anything input or if there is just white space 
                //description  is the variable that is assigned to 
                {
                    MessageBox.Show("Warning");
                    //pop up message that shows the warning because description is empty
                    throw new ArgumentException("Please Enter a Expense Description");
                    //this is argument exception that will then show this message above 
                }

                Expense newExpense = new Expense(amount, description, DateTime.Now);
                //new Instance of Expense class, which will intialize all the variable
                ////this will occur everytime a new one is listed 
                expenses.Add(newExpense);
                //will callback to List<expense> and be stored there 
                //the new expense w//all variables will go to expense list 

                totalExpenses += amount;
                //once the new expense is added the total expense will then update 
                //by adding amount variable it is able to count up all costs 
                lblTotal.Text = $"Total Expenses: ${totalExpenses:F2}";
                // pulls up with two decimals 

                dgvExpense.Rows.Add(newExpense.Date.ToString("MM/dd/yyyy"), newExpense.Description, $"${newExpense.Amount:F2}");
                //this will add a new row to the datagridview with a new row that has the expense name, 
                //expense cost and date and time
                txtExpenseCost.Clear();
                //once done with everything cost expense will go away ready for a new one
                txtExpenseName.Clear();
                //the same thing with expense name 

            }
            catch (FormatException ex)
            //this is an exception that will catch if the format is wrong and will come back with the following message
            {
                MessageBox.Show("Please put a valid number and Item description");
            }
            catch (ArgumentException ex)
            {//this exceptions will catch if the argument or if nothing is put in so no valid argument 
                MessageBox.Show("Warning!Missing Information!Please enter a valid input.");
            }
        }



        private void txtExpenseCost_TextChanged(object sender, EventArgs e)
        {
            //i wrote this because of an error in designer 
            //this was one of the recommended fixes
        }

        private void txtExpenseName_TextChanged(object sender, EventArgs e)
        {
            //the same thing occured with designer 
        }

        private void bttnRemoveExpense_Click(object sender, EventArgs e)
        {//thevent handler that shows what happens when the button is clicked 
            string descriptionToRemove = txtExpenseName.Text.Trim();
            //will use the string value in description to correlate to the expense name and trims away any space so it
            //doesnt look wierd 
            MessageBox.Show($"Attempting to remove : {descriptionToRemove}"); //debugging error
            RemoveExpense(descriptionToRemove); // Call the remove function
            txtExpenseName.Clear(); //will clear the input after removing it 
        }

        private void RemoveExpense(string descriptionToRemove)
        {//method named  Remove Expense, uses string so letters, and parameters are to hold task descritption and will removeit

            bool found = false; //debuging to make sure item is selected and removed

            for (int i = 0; i < expenses.Count; i++) // Loop through expenses
            {//this will go through each expense, start at begining of index, 
                //will count the right way and also go through to next expense 
                Console.WriteLine($"Checking Expense: {expenses[i].Description}"); 
                if (expenses[i].Description.Equals(descriptionToRemove, StringComparison.OrdinalIgnoreCase))
                {//gets the current list and description, checks first that input mat hes 
                    //makes sure that lower and uppercase dont matter 
                    expenses.RemoveAt(i); // first step removes espense from the index
                    found = true; //shown tht it is found in the text is true
                    //will update the list there as well so that the user can see i 
                    MessageBox.Show($"Expense '{descriptionToRemove}' removed.");
                    //message box will have a pop up show that the description was removed. 
                    return; //this will ensure we exit the loop 
                }
            }
            if (!found)
            {
                MessageBox.Show("Expense not found.");
                //second part of my for statement what happens if the parameters above 
                //dont work this message box will then show 
                //also a good practice of debugging 
            }
            else
            {
                // Recalculate the total and update the list after removal
                RecalculateTotal(); // Next step will call the recalculate method which will update the expenses 
                UpdateExpenseList(); // this refers to the data grid view 
            }

        }
        private void RecalculateTotal()
        {//private to this class  and Recaculate total is the method name
            totalExpenses = 0; // makes it 0 and resets it when pressed 

            foreach (var expense in expenses) // will go thtough everythingin the loop in order to start the recalculation
            {
                totalExpenses += expense.Amount; // This is the mathmatical equation that will add each of the amounts together 
            }

            lblTotal.Text = $"Total Expenses: ${totalExpenses:F2}"; // will show the new amount in the label \
            //there will use decimals 
        }



        private void UpdateExpenseList()
        //method called Update Expense list  private to this class 

        {
            dgvExpense.Rows.Clear(); // will first clear everything out of the data grid view list so that it can update

            foreach (var expense in expenses) // will go through each expense again to re add everything 
                                              // this is a type of loop centered to Expense(s)
            {
                dgvExpense.Rows.Add(expense.Date.ToString("MM/dd/yyyy"), expense.Description, $"${expense.Amount:F2}");
                //this shows what we want the expenses to look like
                //first we want to add a row each time there is a new expense 
                //this will include the date(with the specific format we implemented)
                //the descitpion and the expense amount
          
            }
            RecalculateTotal();
            dgvExpense.Refresh();

           
            
        }

        
    }
}
