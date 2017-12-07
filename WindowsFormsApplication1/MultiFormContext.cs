using System;

public class MulitFormContext : System.Windows.Forms.ApplicationContext
{
    private int openForms;
    public MulitFormContext(params System.Windows.Forms.Form[] forms)
    {
        openForms = forms.Length;
        foreach (var form in forms)
        {
            form.Show();
        }
    }
}
