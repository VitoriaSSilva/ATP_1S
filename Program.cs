int i, tipoVeiculo, quantHoras, quantVeiculos,quantCarros=0,quantMotos=0,VeiculoTempMaior=0;
double valorHoraCarro,valorHoraMoto,valorTotal=0, somaCarro=0, somaMoto=0;

Console.WriteLine("Informe a quantidade de Veiculos que entraram no estacionamento hoje: ");
quantVeiculos = int.Parse(Console.ReadLine());

for (i = 1; i <= quantVeiculos; i++)
{
    Console.WriteLine($"Informe o tipo do {i}º veiculo\n1 ---- Carro\n2 ---- Moto: ");
    tipoVeiculo = int.Parse(Console.ReadLine());

    Console.WriteLine("Quantas horas o veiculo permaneceu no estabelecimento: ");
    quantHoras = int.Parse(Console.ReadLine());

    if(tipoVeiculo == 1)//veiculo é um carro
    {
       quantCarros++;
        if (quantHoras <= 2)
        {
            valorHoraCarro = 15;
            somaCarro = somaCarro +valorHoraCarro;
        }
        else
        {
            VeiculoTempMaior++;
            valorHoraCarro = 5*(quantHoras-2) +15;
            somaCarro = somaCarro+valorHoraCarro;
        }
        Console.WriteLine($"O {i}º veiculo pagara : {valorHoraCarro} ");
        Console.WriteLine("--------------------------------------");

    }
    else if(tipoVeiculo == 2) // veiculo é uma moto
    {
        quantMotos++;
        if (quantHoras <= 2)
        {
            valorHoraMoto = 8;
            somaMoto = valorHoraMoto+somaMoto;
        }
        else
        {
            
            valorHoraMoto = 3*(quantHoras-2)+8;
            somaMoto = somaMoto+valorHoraMoto;
            VeiculoTempMaior++;
            
        }
        Console.WriteLine($"O {i}º veiculo pagara : {valorHoraMoto} ");
        Console.WriteLine("--------------------------------------");

    }

    valorTotal = somaCarro+somaMoto;
}
Console.WriteLine("--------------------------------------");
Console.WriteLine("           Controle Diario            ");
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Veiculos Atendidos: {quantVeiculos}\nCarros Atendidos: {quantCarros}\nMotos Atendidas: {quantMotos}\nValor Total Arrecadado:R$ {valorTotal} \nVeiculos que permaneceram mais de 2 horas:{VeiculoTempMaior}");
