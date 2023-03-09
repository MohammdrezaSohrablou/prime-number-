
//  Mohammadreza Sohrablou ----------- محمدرضا سهراب لو //

using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

double score;
bool a;
string input;
do
{
    
    num0to20();
    string rank = rankofgrade(score);
    percentageANDoutput(score, rank);
    AskToContinue();

} while (input.ToLower() == "y");
Console.WriteLine("Good Luck !");


//-------------------- Methods --------------------// 


// This method only accepts numbers from 0 to 20
void num0to20()
{
    do
    {
        Console.WriteLine("Enter your grade: ");
        score = double.Parse(Console.ReadLine());
        if (score < 0 || score > 20)
        {
            a = true;
            Console.WriteLine("invalid number! enter a number between 0 and 20");
        }
        else
        {
            a = false;
        }
    } while (a);
}

// This method calculates the rank of your score
static string rankofgrade(double score)
{
    if (score >= 17)
    {
        return("Excellent, Your grade is A");
    }
    else if (score >= 15)
    {
        return ("Good Job, Your grade is B");
    }
    else if (score >= 10)
    {
        return ("Not Bad, Your grade is C");
    }
    else
    {
        return ("Failed");
    }
    
}

// This method calculates the percentage and shows the output
void percentageANDoutput(double score , string rank)
{
    double percentage = (score / 20) * 100;
    Console.WriteLine(rank);
    Console.WriteLine("percentage:"+percentage+"%");
}

//This method locks the keyboard and only accepts letters 'Y' and 'N'
void AskToContinue()
{
    Console.WriteLine("Do you want to continue? y,n:");
    do
    {
        input = Console.ReadKey(true).KeyChar.ToString();
    } while (input.ToLower() != "y" && input.ToLower() != "n");
}
