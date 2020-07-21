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
				
				//gonna use a switch case
			}
			
		}
		public static void Start(){
			Console.Clear();
			Console.WriteLine("Stellar Witch");
			Console.WriteLine("Press enter to start.");
			Console.ReadLine();
			Menu();
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
	public Textbox();
		public void CreateTextBox() {
   		TextBox textBox1 = new TextBox();
    		textBox1.Font = new Font ("Arial" , 20);
    		textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    		textBox1.Height = textBox1.PreferredHeight;
		textBox1.text="BEEP BEEP BEEP.*The sound of an alarm clock rings througout the room*";
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
