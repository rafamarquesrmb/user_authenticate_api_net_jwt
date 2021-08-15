namespace UserAuthenticate
{
    public static class Settings
    {

        //SHA-256 hash for "test":9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08
        public static string Secret = "9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08";
        
        // PT-BR
        // OBSERVAÇÃO: Em uma aplicação real, é extremamente importante que essa chave seja guardada em total segredo,
        // Essa é a chave segredo da criptografia que vai gerar nossos tokens.
        // No caso desta aplicação, ela esta neste repositório apenas para efeitos didáticos. Em uma aplicação real, este arquivo e diretório estaria dentro do meu .gitignore.

        // EN-US
        // NOTE: In a real application it is extremely important that this key is kept completely secret,
        // This is the secret encryption key that will generate our tokens.
        // In the case of this application, it is in this repository for educational purposes only. In a real application, this file and directory would be inside my .gitignore.

    }
}