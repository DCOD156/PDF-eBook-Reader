using Paroxe.PdfRenderer;
using UnityEngine;
public class PDFLoader : MonoBehaviour
{

    //public PDFViewer pdfViewer;
    public static PDFLoader instance;

    private void Awake()
    {
        instance = this;
    }
    //public void LoadPDF(string filePath)
    //{



    //    PDFReader.Instance.pDFViewer.gameObject.SetActive(true);



    //    Debug.Log("PDF Loaded Successfully: ot of if ----" + filePath);
    //    // Check if the file exists at the given path
    //    if (System.IO.File.Exists(filePath))
    //    {
    //        // Load and display the PDF in the viewer
    //        PDFReader.Instance.pDFViewer.LoadDocumentFromFile(filePath);
    //        Debug.Log("PDF Loaded Successfully: " + filePath);
    //    }
    //    else
    //    {
    //        Debug.Log("PDF file not found at path: " + filePath);
    //    }
    //}

    //// Example method to call LoadPDF with a specific path
    //public void LoadPDFExample()
    //{
    //    string customPath = "C:/Users/YourUsername/Documents/yourfile.pdf"; // Replace with your path
    //    //LoadPDF(customPath);
    //}
}