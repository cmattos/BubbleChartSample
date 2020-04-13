<h1> Gráfico de Bolhas com C# e Microsoft.Office.Interop.Excel</h1>

<i>Exemplo de aplicação Windows Forms (C#) demonstrando a utilização do namespace Microsoft.Office.Interop.Excel para criar um gráfico de bolhas (Bubble Chart) dinamicamente. </i>

<img src="/Screenshots/BubbleChartSample4.png" />

<h2>Pré-requisitos:</h2>
<ul>
	<li>Visual Studio Code (Download)
	<li>Microsoft Excel 16.0 Object Library
	<li>.NET Framework 4.7.2
</ul>

<h2>Motivação</h2>
A origem desta apliaçação de exemplo está no exercício para apresentar de forma visual e dinâmica, a capacidade e senioridade, de uma determinada empresa, em grupos de tecnologias, representadas num modelo de quadrante, seguindo o conceito abaixo: 

<h2>
<img src="/Screenshots/quadrant_definition.png" height="250px" width="400px"/>
</he>

<h2>Exemplo desta representação gráfica: </h2>

<img src="/Screenshots/quadrant_sample.png" height="400px" width="600px"/>

<h2>Screenshots:</h2>

<img src="/Screenshots/BubbleChartSample1.png" /></br>
<img src="/Screenshots/BubbleChartSample2.png" /></br>
<img src="/Screenshots/BubbleChartSample3.png" /></br>


<h2>Funcionalidades ilustradas: </h2>
<ul>
	<li>Instanciar Microsoft Excel</li>
	<li>Adicionar Gráfico de Bolha numa Planilha</li>
	<li>Personalizar os Eixos X e Y do Gráfico</li>
	<li>Personalizar os Labels dos Dados ValuesFromCells</li>
</ul>

```
private void SetDataLabelsValuesFromCells(Worksheet reportWorksheet, Series series1)
{
    int msoChartFieldRange = 7;
    int msoFieldPosition = 0;

    Range technologyRange = reportWorksheet.Range["TechnologyRange"];
    string technologyRangeAbsoluteAddress = "=" + technologyRange.Worksheet.Name + "!" 
    + technologyRange.Address;

    series1.DataLabels(0).Format.TextFrame2.TextRange.InsertChartField(msoChartFieldRange, 
    technologyRangeAbsoluteAddress, msoFieldPosition);
}
```

<ul>
	<li>Adicionar Campos Customizados no Gráfico</li>
	<li>Aplicar Estilos no Gráfico</li>
	<li>Aplicar Cores Dinamicamente para os Data Points </li>
	<li>Nomear e Consumir Ranges de Planilhas (Worksheets)</li>
	<li>Capturar/Exportar Gráfico em formato PNG </li>
</ul>

```
chartPage.CopyPicture();
reportWorksheet.Paste();
reportWorksheet.Shapes.Item(reportWorksheet.Shapes.Count).Cut();

BitmapEncoder bmpEncoder = new BmpBitmapEncoder();
bmpEncoder.Frames.Add(BitmapFrame.Create(System.Windows.Clipboard.GetImage()));

using (System.IO.MemoryStream outStream = new System.IO.MemoryStream())
{
	bmpEncoder.Save(outStream);
	System.Drawing.Image imgGraph = new System.Drawing.Bitmap(outStream);
	imgGraph.Save(chartImageFilename.ToString());
}
```

<ul>
	<li>Converter uma Range em Lista Genérica</li>
</ul>

```
private List<string> RangeToList(Range rangeToConvert)
{
    object[,] cellValues = (object[,])rangeToConvert.Value2;
    List<string> listRangeValues = cellValues.Cast<object>().ToList().ConvertAll(x => Convert.ToString(x));
    return listRangeValues;
}
```

<ul>
	<li>Salvar Excel Workbook</li>
	<li>Carregar ComboBox e ListBox com objetos Dictionary<string, int></li>
	<li>Manipular Pastas e Arquivos com System.IO</li>
	<li>Identificar Arquivo Mais Recente numa Determinada Pasta</li>
</ul>

```
private FileInfo GetNewestFile(DirectoryInfo directory, string filePattern)
{
    return directory.GetFiles(filePattern)
	.Union(directory.GetDirectories().Select(folderInfo => GetNewestFile(folderInfo, filePattern)))
	.OrderByDescending(newestFile => (newestFile == null ? DateTime.MinValue : newestFile.LastWriteTime))
	.FirstOrDefault();
}
```

<ul>
	<li>Criptografar Sessão de Strings de Conexão no Arquivo App.config</li>
</ul>

```
public static void ToggleSectionEncryption(string appConfigName, string sectionName)
{
    Configuration config = ConfigurationManager.OpenExeConfiguration(appConfigName);

    ConnectionStringsSection section =
	config.GetSection(sectionName) as ConnectionStringsSection;

    if (!section.SectionInformation.IsProtected)
    {
	section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
    }
    else
    {
	section.SectionInformation.UnprotectSection();
    }

    config.Save();
}
```
