namespace Treehouse.MediaLibrary
{
    class Album
    {
        public readonly string Title;
        public readonly string Artist;
        public string Loanee = null;
        public bool OnLoan = false;
      

      
        public Album(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }
      
        public void Loan()
        {
          OnLoan = true;
        }
      
        public void Loan(string loanee)
          
        {
          Loanee = loanee;
          Loan();
        }
      
        public void Return()
        {
          Loanee = null;
          OnLoan = false;
        }
      
        public string GetDisplayText()
        
        {
            string text = "Album: " + Title + " by " + Artist;
          
            if (OnLoan)
            {
              if (!string.IsNullOrEmpty(Loanee))
              {
                text = text + " (Currently on loan to " + Loanee + ")";
              }
              else
              {
                text += " (currently on loan)";
              }
            }
          
            return text;
        }
    }
}