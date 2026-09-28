int n,i, astrogildo,telbaldo,voto, votosAstrogildo=0,votosTelbaldo=0,votosBranco=0,votosNulo=0;

do
{
    Console.WriteLine("Informe o numero de eleitores: ");
    n=int.Parse(Console.ReadLine());
    
} while (n<10);

 do
 {
    Console.WriteLine("Informe o numero do candidato astrogildo: ");
    astrogildo =  int.Parse(Console.ReadLine());

 } while (astrogildo ==0);

do
{
    
    Console.WriteLine("Informe o numero do candidato Telbado: ");
    telbaldo =  int.Parse(Console.ReadLine());
    
    
} while (telbaldo ==0 || (telbaldo == astrogildo));

for (i = 1; i <= n; i++)
{
    Console.WriteLine("Informe seu voto: ");
    voto = int.Parse(Console.ReadLine());

    if (voto == astrogildo)
    {
        votosAstrogildo++;
    }
    else if(voto == telbaldo)
    {
        votosTelbaldo++;
    }
    else if(voto == 0)
    {
        votosBranco++;
    }
    else
    {
        votosNulo++;
    }
}

if (votosTelbaldo > votosAstrogildo)
{
    Console.WriteLine($"Ganhador: Telbaldo\nQuantidade de Votos: {votosTelbaldo} ");
}
else
{
    Console.WriteLine($"Ganhador: Astrogildo\n Quantidade de Votos: {votosAstrogildo}");
}
Console.WriteLine($"Votos em Branco: {votosBranco}");
Console.WriteLine($"Votos em Nulo: {votosNulo}");