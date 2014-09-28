
using System.Drawing;
using Novacode;

namespace Word_Document_Generator
{
    public class WordGenerator
    {
        static void Main()
        {
            string FileName = @"D:\OOP\Homeworks\Homework_04\GalacticGPS\Word_Document_Generator\Output items\Word.docx";
            using (var doc = DocX.Create(FileName))
            {
                //header
                string Header = "SoftUni OOP Game Contest";
                var HeaderFormat = new Formatting();
                HeaderFormat.Bold = true;
                HeaderFormat.Position = 25;
                HeaderFormat.Size = 20D;

                var header = doc.InsertParagraph(Header,false,HeaderFormat);
                header.Alignment = Alignment.center;

                //read image from file,resize and position
                Picture image = doc.AddImage(@"D:\OOP\Homeworks\Homework_04\GalacticGPS\Word_Document_Generator\Input Assets\rpg-game.png").CreatePicture();
                
                image.Height = 200;
                image.Width = 520;

                var picParagraph = doc.InsertParagraph("");
                picParagraph.InsertPicture(image);
                picParagraph.Alignment = Alignment.center;

                Paragraph mainText = doc.InsertParagraph("", false);
                mainText.Append("SoftUni is organizing a contest for the best ").
                Append("role playing game ").Bold().
                Append("from the OOP teamwork ").
                Append("projects. The winnig teams will receive a ").
                Append("grand prize").Bold().
                Append("!").
                AppendLine("The game shoud be: ");
                mainText.IndentationAfter = 2.0f;

                var bulletedList = doc.AddList("Properly structured and follow all good OOP practices", 0, ListItemType.Bulleted);
                doc.AddListItem(bulletedList, "Awesome");
                doc.AddListItem(bulletedList, "..Very Awesome");

                doc.InsertList(bulletedList);
                doc.InsertParagraph("");

                Table teamsResultTable = doc.AddTable(4, 3);
                teamsResultTable.Alignment = Alignment.center;
                teamsResultTable.AutoFit = AutoFit.Window;
                teamsResultTable.Rows[0].Cells[0].FillColor = Color.FromArgb(84, 141, 212);
                teamsResultTable.Rows[0].Cells[0].Paragraphs[0].Append("Team").Color(Color.White).Bold().Alignment = Alignment.center;
                teamsResultTable.Rows[0].Cells[1].FillColor = Color.FromArgb(84, 141, 212);
                teamsResultTable.Rows[0].Cells[1].Paragraphs[0].Append("Game").Color(Color.White).Bold().Alignment = Alignment.center;
                teamsResultTable.Rows[0].Cells[2].FillColor = Color.FromArgb(84, 141, 212);
                teamsResultTable.Rows[0].Cells[2].Paragraphs[0].Append("Points").Color(Color.White).Bold().Alignment = Alignment.center;
                teamsResultTable.Rows[1].Cells[0].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[2].Cells[0].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[3].Cells[0].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[1].Cells[1].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[2].Cells[1].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[3].Cells[1].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[1].Cells[2].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[2].Cells[2].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[3].Cells[2].Paragraphs[0].Append("-").Alignment = Alignment.center;
                doc.InsertTable(teamsResultTable);

                Paragraph footText1 = doc.InsertParagraph("", false);
                footText1.Append("The top 3 teams will receive a ").
                Append("SPECTACULAR").Bold().
                Append(" prize:");
                footText1.Alignment = Alignment.center;

                Paragraph footText2 = doc.InsertParagraph("", false);
                footText2.Append("A HANDSHAKE FROM NAKOV").Color(Color.Blue).Bold().UnderlineColor(Color.Blue);
                footText2.Alignment = Alignment.center;

                doc.Save();
            }
        }
    }
}
