


//https://docs.microsoft.com/es-es/dotnet/standard/base-types/regular-expression-language-quick-reference
//Ejemplo 1 matches 
using System.Text.RegularExpressions;

string frase = "A developer lives like olive oil – Always adding good taste to what they do?";
string patron = "[A]";

Regex regex = new Regex(patron);
MatchCollection matches1 = regex.Matches(frase);
int total = matches1.Count();

//Ejemplo 2 matches ignorando mayusc y minusc
string patron2 = "li";
MatchCollection matches2 = Regex.Matches(frase, patron2, RegexOptions.IgnoreCase);
foreach (Match match2 in matches2)
{
    Console.WriteLine(match2.Index);
}

//Ejemplo 3  match 
Match result3 = Regex.Match(frase, patron);

//Ejemplo4 ismatch

bool result4 = Regex.IsMatch(frase, patron);


//Ejemplo 5 Con caracter de escape 
Match result5 = Regex.Match(frase, @"do\?");


//Ejemplo 6 Conjuntos_ [ ] [ - ] [^] [^ - ] \d \D \w \s . 
Match result6 = Regex.Match(frase, @"[Aa]l");

Match result6b = Regex.Match(frase, @"[^Aa]l");

Match result6c = Regex.Match(frase, @"\w");

MatchCollection result6d = Regex.Matches(frase, @"\w");


//Ejemplo 7 Anchors ^ $ 

Match result7 = Regex.Match(frase, @"^\w");



//Ejemplo 8 Cuantificadores * + ? { } { ,} { , }

string frase8 = "Aquí tienes mi número de telefono (+34)666-66-66-66 y mi código 022-991";
string patron8 = @"\d{3}";
Regex regex8 = new Regex(patron8);
MatchCollection match8 = regex8.Matches(frase8);
int total2 = match8.Count();

//Categorias \p{vategoria}

MatchCollection resultado = Regex.Matches(frase8, @"t\p{L}l");


//Grupos (  ) 

Match resultado2 = Regex.Match(frase8, @"(\d\d\d)-(\d\d\d)");




///Ejercicios:
///


string formatofecha = @"(\d{2})/(\d{2})/(\d{4})";

string formatofecha2 = "";

string formatoCorreo = @"^\w+@\w+\.\w{2,3}$";

string formatotelefono = @"(\d\d\d)-(\d\d\d)-(\d\d\d\d)";

string formateoIp = @"";

string formateoMac = @"";

string letra = "a";

string formateoLetra = $@"[{letra}]\w*";



MatchCollection ejercicio1 = Regex.Matches("12/05/1999", formatofecha);

MatchCollection ejercicio2 = Regex.Matches("pepe@gmail.com", formatoCorreo);
MatchCollection ejercicio2_2 = Regex.Matches("pepa@hotmail.com", formatoCorreo);

MatchCollection ejercicio3 = Regex.Matches("amigo atiende ahora", formateoLetra);

MatchCollection ejercicio4 = Regex.Matches("123-123-1234", formatotelefono);





Console.WriteLine();
