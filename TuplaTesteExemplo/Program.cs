
using TuplaTesteExemplo.ArquivoLeitura;

LeitorDeArquivo leitor = new LeitorDeArquivo("ArquivoLeitura/ArquivoParaLer.txt");
// (bool Sucesso, string[] LinhasArquivo, int QtdLinhas, Exception ex) = leitor.LerArquivo();
(bool Sucesso, string[] LinhasArquivo, _, Exception ex) = leitor.LerArquivo();

if(Sucesso){
    // Console.WriteLine($"A quantidade de linhas foi: {QtdLinhas}");

    foreach(var linha in LinhasArquivo){
        Console.WriteLine(linha);
    }

}else{
    Console.WriteLine($"Erro {ex.Message}");
}