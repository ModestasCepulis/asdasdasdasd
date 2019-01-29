public class ThisIsACLass {

    public static void main(String[] args) {
        String encrypt = "This is a secret message";
        System.out.print(encrypt(encrypt,5));
        System.out.print(decrypt(encrypt, 5));
    }

    public static String encrypt(String plaintext, int numColumns)
    {
        int numRows=0;
        String str = new String ("");
        String ciphertext = "";

        for(int i = 0; i < plaintext.length(); i++)
        {
            char ch = plaintext.charAt(i);

            if(ch!= ' ')
            {
                str = str + ch;
            }
        }

        if(str.length() % numColumns == 0)
        {
            numRows = str.length()/numColumns;
        }

        for(int col = 0; col < numColumns - 1; col++)
        {
           int index = col;

            for(int row = 0; row < numRows; row++)
            {
                ciphertext = ciphertext + str.charAt(index);
                index += numColumns;
            }

        }

        return ciphertext;
    }

    public static String decrypt(String plaintext, int numColumns)
    {
        String decryptedText = "";




        return decryptedText;

    }

}
