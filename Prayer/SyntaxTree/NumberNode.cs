using System;
public class NumberNode : SyntaxNode{
    public decimal Value { get; }
    public NumberNode(string value) {
        string[] places = value.Split(' ');
        int number = 0;
        for (int i = places.Length-1; i >= 0  ; i--){
            number = number + ((places[places.Length-i-1].Length)%10)*(int)Math.Pow(10,i);   
        }
        this.Value = number;
        }
        
    public override string ToString()
    {
        return ($"number:{Value}");
    }
}
