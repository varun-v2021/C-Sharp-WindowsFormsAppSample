using System;

public class MulitFormContext : ApplicationContext
{
    private int openForms;
	public MulitFormContext(params Form[] forms)
	{
        openForms = forms.Length;
        foreach (var form in forms) {
            form.Show();    
        }
	}
}
