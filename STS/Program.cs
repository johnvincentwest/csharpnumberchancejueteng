//What is this program
//This is a simple number gambling game that is very popular in the Philippines called "JUETENG" (hwe-teng)
//Basically you choose 2 number then you assign a money value to it.
//If 2 of your number guess is correct then your money value will be multiplied to 700
//Numbers are only between 1 to 38 and is randomly generated
using System;

namespace STS
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Jueteng Online System");
			Console.WriteLine(" ");
			//english translation: how to play? put 2 numbers make sure to have put space between them
			Console.WriteLine("Paano TUMAYA? Ilagay lang ang iyong dalawang numero lagyan ng space");
			//english translation: what are your number?
			Console.WriteLine("Ano ang iyong numero?");

			//this command lets you write your number then the .Split is use for space that seperate your number
			//then convert the var to int32 and into a list
			var numbers = Console.ReadLine();
			var numberList = numbers.Split(' ');
			Random random = new Random();
			var number1 = Convert.ToInt32(numberList[0]);
			var number2 = Convert.ToInt32(numberList[1]);
			//second readline for bet
			//english translation: how much is your bet? / example on how to bet
			Console.WriteLine(" ");
			Console.WriteLine("Magkano ang iyong taya?");
			Console.WriteLine("Example P20 P5 Pesos");
			Console.WriteLine("No need for Peso sign, please put spaces between your bet");
			//split the two input by the user then convert to int32 and put in to a list
			var bet = Console.ReadLine();
			var betList = bet.Split(' ');
			var bet1 = Convert.ToUInt32(betList[0]);
			var bet2 = Convert.ToUInt32(betList[1]);
			//generate random numbers between 1 and 32 first number
			int firstRandomNum = random.Next(1, 39);
			int secondRandomNum = random.Next(1, 39);
			Console.WriteLine(" ");
			Console.WriteLine("ANG TUMAMA AY " + firstRandomNum + " " + secondRandomNum);
			Console.WriteLine("Ang numero mo ay " + number1 + " " + number2);
			//generate random numbers between 1 and 38 second number

			if (number1 == firstRandomNum && number2 == secondRandomNum)
			{
				//english translation: YOU WIN CELEBRATION!!
				Console.WriteLine("*IKAW AY TUMAMA MAYAMAN KANA!!");
			}
			else
			{
				//english translation: YOU LOSE, YOUR MONEY IS WASTED >:D
					Console.WriteLine(" ");
				//it add up your bets and how much you lose
				Console.WriteLine("LUGE KA NG " + (bet1 + bet2) +" Pesos");
				Console.WriteLine("*IKAW AY ISANG TALUNAN SAYANG PERA MO");

			}
		}
	}
}
