using System;
namespace StellarWitch{
	class Game{
		static bool Run= true;
		public static void Menu(){
			Console.Clear();
			Console.WriteLine("Start game");
			Console.WriteLine("Load game");
			Console.WriteLine("Credits");
			Console.WriteLine("End game");
			//how to connect the mouse clicking to interface with if/switch
			if (Choice=="End Game"){
				Run= false;
			}
			else{
				Start();
				//gonna use a switch case
			}
			
		}
		public static void Start(){
			Console.Clear();
			Console.WriteLine("Stellar Witch");
			Console.WriteLine("Press enter to start.");
			Console.ReadLine();
		}
		public static void End(){
			Run=true;
			Play();
		}
		public static void Play(){
			Start();
			while (Run==true){
				Menu();
			}
			End();
		}
	}
	class Program{
		static void Main(string[] args){
			Game.Start();
			Console.WriteLine("Welcome to Stellar Witch");
			Game.Play();
			Console.ReadKey();
		}
	}
}