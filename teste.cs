public class Solution {
    public bool DetectCapitalUse(string word) {
        return word.All(char.IsUpper) || word.All(char.IsLower) ||
            (char.IsUpper(word[0]) && word.Substring(1).All(char.IsLower));
    }
}
// A ideia é, de todas as letras da palavras forem maiúsculas, deve retornar True, se for todas minúsculas, True também, além de que se apenas a primeira letra for maiuscula, tambem deve retornar True. Logo, se apenas uma condição for verdadeira, vem o True, caso contrário, o False.