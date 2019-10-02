
namespace UI
{
    class Program
    {

        static void Main(string[] args)
        {
            LogInFormD logInForm = new LogInFormD();

            logInForm.ShowDialog();

            int numOfGuesses = logInForm.GetNumOfGuesses;

            BoolPgiaForm game = new BoolPgiaForm(numOfGuesses);

            game.ShowDialog();
            
        }
    }
}
