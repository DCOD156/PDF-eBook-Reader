using UnityEngine;
using Paroxe.PdfRenderer;
using System.Collections;

public class PDFReader : MonoBehaviour
{
    public PDFViewer pDFViewer;
    public static PDFReader Instance;
    public string FinalPath;
    private string pdfFileType;


    private async void Start()
    {
        Instance = this;
        pdfFileType = NativeFilePicker.ConvertExtensionToFileType("pdf"); // Returns "application/pdf" on Android and "com.adobe.pdf" on iOS
        //bug.text = ("\n\npdf's MIME/UTI is: " + pdfFileType);
        Debug.Log("pdf's MIME/UTI is: " + pdfFileType);
        NativeFilePicker.Permission permission = await NativeFilePicker.RequestPermissionAsync(false);
        Debug.Log("Permission result: " + permission);
        //bug.text = ("\n\nPermission result: " + permission);
    }
    public async void LoadFile()
    {
        //string FileType = NativeFilePicker.ConvertExtensionToFileType("*");

        NativeFilePicker.Permission permission = NativeFilePicker.PickFile((path) =>
        {
            if (path == null)
            {
                Debug.Log("Operation cancelled");
                //bug.text = "Operation cancelled";
            }
            else
            {
                FinalPath = path;
                Debug.Log("Picked File : " + FinalPath);

                StartCoroutine("testOpen", FinalPath);

                //bug.text = ("Picked File : " + FinalPath);
            }
        }, new string[] { pdfFileType });

    }

    IEnumerator testOpen(string filePath)
    {
        if (System.IO.File.Exists(filePath))
        {
            yield return System.IO.File.Exists(filePath);
            pDFViewer.gameObject.SetActive(true);
            // Load and display the PDF in the viewer
            pDFViewer.LoadDocumentFromFile(filePath);
            Debug.Log("PDF Loaded Successfully: " + filePath);
        }
        else
        {
            Debug.Log("PDF file not found at path: " + filePath);
        }

    }



    public void LoadPDF(string filePath)
    {
        pDFViewer.gameObject.SetActive(true);

        Debug.Log("PDF Loaded Successfully: ot of if ----" + filePath);
        // Check if the file exists at the given path
        if (System.IO.File.Exists(filePath))
        {
            // Load and display the PDF in the viewer
            pDFViewer.LoadDocumentFromFile(filePath);
            Debug.Log("PDF Loaded Successfully: " + filePath);
        }
        else
        {
            Debug.Log("PDF file not found at path: " + filePath);
        }
    }


    public void ExitGame()
    {
        Application.Quit();
    }





}
