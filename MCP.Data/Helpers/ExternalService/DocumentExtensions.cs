namespace MCP.Data.Helpers.ExternalService
{
    /// <summary>
    ///     Provides extension methods for working with document extensions.
    /// </summary>
    public static class DocumentExtensions
    {
        private static readonly string[] DocumentExtensionsArray =
            { "pdf", "jpg", "txt", "mov", "mp4", "avi", "jpeg", "bmp", "gif", "png", "xml", "jfif" };

        /// <summary>
        ///     Determines whether the given file name is a document with an allowed extension.
        /// </summary>
        /// <param name="fileName">The name of the file to check.</param>
        /// <param name="allowedExtensions">The allowed document extensions.</param>
        /// <returns>True if the given file name is a document with an allowed extension, otherwise false.</returns>
        public static bool IsDocument(this string fileName, string[] allowedExtensions)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            if (allowedExtensions == null)
            {
                throw new ArgumentNullException(nameof(allowedExtensions));
            }

            var ext = Path.GetExtension(fileName);
            return allowedExtensions.Contains(ext,
                StringComparer.OrdinalIgnoreCase); // Use case-insensitive comparison to be more lenient.
        }

        /// <summary>
        ///     Determines whether the given file name is a document with a default allowed extension.
        /// </summary>
        /// <param name="fileName">The name of the file to check.</param>
        /// <returns>True if the given file name is a document with a default allowed extension, otherwise false.</returns>
        public static bool IsDocument(this string fileName)
        {
            return fileName.IsDocument(DocumentExtensionsArray);
        }
    }
}