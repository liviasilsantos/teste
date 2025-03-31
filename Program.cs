//1.Calcular e exibir a média geométrica de dois valores quaisquer que serão digitados.  

//
float n1, n2, mediag;
Console.Write("Digite o primeiro número: ");
n1 = float.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
n2 = float.Parse(Console.ReadLine());
mediag = MathF.Sqrt(n1 * n2);
Console.WriteLine("A média geométrica é {0}", mediag);
Console.ReadKey();
Console.Clear();

////2. Sabendo que uma milha marítima equivale a um mil, oitocentos e cinquenta e dois metros e que um quilômetro possui mil metros,
////fazer um programa para converter milhas marítimas em quilômetros.  

float milham, km;
Console.Write("Digite o valor em milhas marítimas: ");
milham = float.Parse(Console.ReadLine());
km = milham * 1.852f;
Console.WriteLine("{0} milhas marítimas equivalem a {1} quilômetros",
milham, km);
Console.ReadKey();
Console.Clear();


////3. Calcular e exibir a tensão de um determinado circuito eletrônico a partir dos valores da resistência e corrente elétrica que
////serão digitados. Utilize a lei de Ohm.  
// U = r.i
float tensao,resistencia,corrente;
Console.Write("Digite o valor da resistência elétrica: ");
resistencia = float.Parse(Console.ReadLine());
Console.Write("Digite o valor da corrente elétrica: ");
corrente = float.Parse(Console.ReadLine());
tensao = resistencia * corrente;
Console.WriteLine("O valor da tensão elétrica é de: {0}", tensao);
Console.ReadKey();
Console.Clear();



////4. Entrar via teclado com o valor de uma temperatura em graus Celsius, calcular e exibir sua temperatura equivalente em Fahrenheit.  
float F, C;
Console.Write("Digite o valor em Celsius : ");
C = float.Parse(Console.ReadLine());
F = C * 1.8f + 32;
Console.WriteLine("{0}°C equivale á {1}°F", C, F);
Console.ReadKey();
Console.Clear();


//5. A partir do diâmetro de um círculo que será digitado, calcular e exibir sua área.
float diametroc, raioc, areac;
Console.Write("Digite o diâmetro do círculo: ");
diametroc = float.Parse(Console.ReadLine());
raioc = diametroc / 2;
areac = MathF.PI * MathF.Pow(raioc, 2);
Console.WriteLine("A área do círculo é: {0}", areac);
Console.ReadKey();
Console.Clear();


//6. Calcular e exibir o volume de um cone a partir dos valores da altura e do raio da base que serão digitados.  
// V = (π * r² * h) /3

float vCone, raioCone, hCone;
Console.Write("Digite o valor da altura do cone: ");
hCone = float.Parse(Console.ReadLine());
Console.Write("Digite o valor do raio do cone: ");
raioCone = float.Parse(Console.ReadLine());
vCone = (MathF.PI) * MathF.Pow(raioCone, 2)* (hCone)/3 ;
Console.WriteLine("O volume do cone é de: {0} cm³ ", vCone);
Console.ReadKey();
Console.Clear();



//7. Calcular e exibir a velocidade final (em km/h) de um automóvel, a partir dos valores da velocidade inicial (em m/s),
//da aceleração (m/s²) e do tempo de percurso (em s) que serão digitados.
// VF = V0 + AT
float velocidadeFinal, velocidadeInicial, tempoPercurso, Aceleracao;
Console.Write("Digite o valor da Velocidade Inicial: ");
velocidadeInicial = float.Parse(Console.ReadLine());
Console.Write("Digite o valor da Tempo de Percurso: ");
tempoPercurso = float.Parse(Console.ReadLine());
Console.Write("Digite o valor da Aceleração: ");
Aceleracao = float.Parse(Console.ReadLine());
velocidadeFinal = ((tempoPercurso * Aceleracao) + velocidadeInicial) / 3.6f;
Console.WriteLine("O valor da velocidade final é de : {0} km/h", velocidadeFinal);
Console.ReadKey();
Console.Clear();


//8. Calcular e exibir o volume livre de um ambiente que contém uma esfera de raio “r” inscrita em um cubo perfeito de aresta “a”.
//Os valores de “r“ e “a” serão digitados.  
// r = a/2 v=(4/3)*π*r²
float volumearea, raioesfera, arestacubo;
Console.Write("Digite o valor da aresta: ");
arestacubo = float.Parse(Console.ReadLine());
Console.Write("Digite o valor do raio: ");
raioesfera = float.Parse(Console.ReadLine());
raioesfera = arestacubo / 2;
volumearea = MathF.PI * MathF.Pow(raioesfera, 3) * 4 / 3;
Console.WriteLine("O valor do volume é de: {0}", volumearea);
Console.ReadKey();
Console.Clear();


//9. Entrar via teclado com o valor da cotação do dólar e uma certa quantidade de dólares. Calcular e exibir o valor correspondente
//em Reais (R$).  
float dolar, cotacaoDolar, real;
Console.Write("Digite a cotação atual do Dólar $: ");
cotacaoDolar = float.Parse(Console.ReadLine());
Console.Write("Digite quantos dólares você deseja converter: ");
dolar = float.Parse(Console.ReadLine());
real = dolar * cotacaoDolar;
Console.WriteLine("O valor em real é de: {0}", real);
Console.ReadKey();
Console.Clear();




//10. Entrar via teclado com o valor de 5 (cinco) produtos. Após as entradas, digitar um valor referente ao pagamento da somatória
//destes valores. Calcular e exibir o troco que deverá ser devolvido.
float produto1, produto2, produto3, produto4, produto5, pagamento, soma, troco;
Console.Write("Digite o valor do Produto 1: ");
produto1 = float.Parse(Console.ReadLine());
Console.Write("Digite o valor do Produto 2: ");
produto2 = float.Parse(Console.ReadLine());
Console.Write("Digite o valor do Produto 3: ");
produto3 = float.Parse(Console.ReadLine());
Console.Write("Digite o valor do Produto 4: ");
produto4 = float.Parse(Console.ReadLine());
Console.Write("Digite o valor do Produto 5: ");
produto5 = float.Parse(Console.ReadLine());
soma = produto1 + produto2 + produto3 + produto4 + produto5;
Console.WriteLine("O total dos produtos é: {0}", soma);
Console.Write("Digite o valor do pagamento: ");
pagamento = float.Parse(Console.ReadLine());
troco = (pagamento - soma);

if (pagamento >= soma)
{
    Console.WriteLine("O valor do seu troco é de: {0}", troco);

    Console.ReadKey();
    Console.Clear();
    Environment.Exit(0);

}

Console.WriteLine("Verifique novamente! O valor do somatórios dos itens é maior do que o valor informado para pagamento.");


Console.ReadKey();
Console.Clear();










