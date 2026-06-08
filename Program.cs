abstract class Veiculo
{
    public string modelo { get; set; }
    public string cor { get; set; }
    public int ano { get; set; }
    public abstract void ExibirDetalhes();
    public abstract double CalcularCustoManutencao();
    public Veiculo(string modelo, string cor, int ano)
    {
        this.modelo = modelo;
        this.cor = cor;
        this.ano = ano;
    }
}
class Carro : Veiculo
{
    public int numPortas { get; set; }
    public string tipoCombustivel { get; set; }
    public override void ExibirDetalhes()
    {
        System.Console.WriteLine($"Modelo: {this.modelo} - Ano: {this.ano} - Modelo: {this.modelo}\nNumero de Portas: {this.numPortas} - Tipo de Combustível: {this.tipoCombustivel}");
    }
    public override double CalcularCustoManutencao()
    {
        return 235.20;
    }
    public Carro(string modelo, string cor, int ano, int numPortas, string tipoCombustivel) : base(modelo, cor, ano)
    {
        this.numPortas = numPortas;
        this.tipoCombustivel = tipoCombustivel;
    }
}
class Moto : Veiculo
{
    public int cilindrada;
    public string tipoPartida;
    public override void ExibirDetalhes()
    {
        System.Console.WriteLine($"Modelo: {this.modelo} - Ano: {this.ano} - Modelo: {this.modelo}\nCilindadas: {this.cilindrada} - Tipo de Partida: {this.tipoPartida}");
    }
    public override double CalcularCustoManutencao()
    {
        return 123.50;
    }
    public Moto(string modelo, string cor, int ano, int cilindrada, string tipoPartida) : base(modelo, cor, ano)
    {
        this.cilindrada = cilindrada;
        this.tipoPartida = tipoPartida;
    }
}
class Caminhao : Veiculo
{
    public double capacidadeCarga { get; set; }
    public int numEixos { get; set; }
    public override void ExibirDetalhes()
    {
        System.Console.WriteLine($"Modelo: {this.modelo} - Ano: {this.ano} - Modelo: {this.modelo}\nCapacidade de carga: {this.capacidadeCarga} - Número de Eixos: {this.numEixos}");
    }
    public override double CalcularCustoManutencao()
    {
        return 1250.70;
    }
    public Caminhao(string modelo, string cor, int ano, double capacidadeCarga, int numEixos) : base(modelo, cor, ano)
    {
        this.capacidadeCarga = capacidadeCarga;
        this.numEixos = numEixos;
    }
}
class FabricaVeiculo
{
    public Veiculo CriarVeiculo(string tipo)
    {
        Veiculo v;
        string modelo, cor, tipoCombustivel, tipoPartida;
        int ano, numPortas, cilindrada, numEixos;
        double capacidadeCarga;
        System.Console.WriteLine("Qual modelo do veiculo?");
        modelo = Console.ReadLine();
        System.Console.WriteLine("Qual a cor do veiculo?");
        cor = Console.ReadLine();
        System.Console.WriteLine("Qual ano do veiculo?");
        ano = int.Parse(Console.ReadLine());

        if (tipo == "carro")
        {
            System.Console.WriteLine("Qual tipo de Combustivel?");
            tipoCombustivel = Console.ReadLine();
            System.Console.WriteLine("Qual numero de portas?");
            numPortas = int.Parse(Console.ReadLine());
            v = new Carro(modelo, cor, ano, numPortas, tipoCombustivel);
            return v;
        }
        else if (tipo == "moto")
        {
            System.Console.WriteLine("Qual tipo de partida?");
            tipoPartida = Console.ReadLine();
            System.Console.WriteLine("Qual cilindrada?");
            cilindrada = int.Parse(Console.ReadLine());
            v = new Moto(modelo, cor, ano, cilindrada, tipoPartida);
            return v;
        }
        else
        {
            System.Console.WriteLine("Qual tipo de Combustivel?");
            numEixos = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual capacidade de caga?");
            capacidadeCarga = double.Parse(Console.ReadLine());
            v = new Caminhao(modelo, cor, ano, capacidadeCarga, numEixos);
            return v;
        }
    }
}
class Program
{
    static void Main()
    {
        int op = 1000;
        string tipo;
        do
        {
            System.Console.WriteLine("Selecione uma opção:");
            System.Console.WriteLine("");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 0:
                    System.Console.WriteLine("Encerrando o programa...");
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    System.Console.WriteLine("Insira uma opção válida!");
                    break;
            }
        } while (op != 0);
    }
}