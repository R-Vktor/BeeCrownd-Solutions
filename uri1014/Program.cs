using System.Globalization;

// sempre que trabalharmos com pontos e virgulas com numeros precisamos do metodo 'System.Globalization' e do 'CultureInfo.InvariantCulture' e nao do'CreateSpecificCulture(" ")' este ultimo faz alteracao para a pontuacao padrao de umdeterminado idioma nativo.
int X = int.Parse(Console.ReadLine());
double Y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double consumo = X/Y;


// como vamos precisar mudificar a exibicao de quantas casas decimais irao aparecer 
// precisaremos usar o metodo 'toString(F3)' com o modificador 'F3' para tres casas decimais após a virgula.
Console.WriteLine(consumo.ToString("F3",CultureInfo.InvariantCulture) + " km/l");