<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# Search API - An example of use


<p>This example illustrates a simple Search API application. It can be useful when standard <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSubDocument_Replacetopic"><u>SubDocument.Replace Method</u></a> capabilities are not sufficient. For instance, let us consider a scenario when it is necessary to replace each match with a varying content that can include formatting (RTF block). The only way of accomplishing this scenario is to use Search API. Call the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSubDocument_StartSearchtopic793"><u>SubDocument.StartSearch Method</u></a> to initiate a search process. Then iterate through the returned ISearchResult and handle all matches in a custom manner. In this particular example, each match is replaced with some static text and a match number in the RTF format.</p><p><strong>See also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E1677">Using the Search and Replace API functionality</a></p>

<br/>


