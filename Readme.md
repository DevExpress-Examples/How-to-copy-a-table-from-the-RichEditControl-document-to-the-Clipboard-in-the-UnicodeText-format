# How to copy a table from the RichEditControl document to the Clipboard in the UnicodeText format

With the current implementation, our RichEditControl component copies each table cell as a separate paragraph into the Clipboard in the Text format. As a result, the tabular structure of the copied content is lost when you paste it into a Notepad or Microsoft Office Excel document. 
You can change this behavior by replacing the default [CopySelectionCommand](https://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditCommandsCopySelectionCommandtopic) command with a custom one.

See the **ExecuteCore** method implementation of the CustomCopySelectionCommand class in this example. In this method text obtained for the OfficeDataFormats.UnicodeText format is postprocessed to separate cell content with Tab symbols.

See also: [E3665: How to customize copy and paste commands](https://www.devexpress.com/Support/Center/Example/Details/E3665/how-to-customize-copy-and-paste-commands) 
