int theNumber=new Random().Next(20);
bool keepGoing=true;
Console.WriteLine("lets play 'guess the number!'");
Console.WriteLine("i am thinking of a number between 0 & 20");
Console.WriteLine("enter your guess,or-i to give up");
int guessNum=0;
int guessCount=0;
do{
    Console.WriteLine("what's your guess?");
    string theGuess=Console.ReadLine();
    bool result=Int32.TryParse(theGuess,out guessNum);
    if(!result)
    {
        Console.WriteLine("that does not look like a number. Try agsin");
      }else
     {
      if(guessNum==-1){
      Console.WriteLine("i was thinking of {the number}");
      keepGoing=false;
      }
      else{
        guessCount ++;
      }
      if(guessNum==theNumber){
        Console.WriteLine($"you got it in{guessCount}gues!!");
        keepGoing =false;
      }
        else{
            Console.WriteLine("nope {0} than that.",guessNum<theNumber?"higher":"lower");
            }
            }
}while(keepGoing);


