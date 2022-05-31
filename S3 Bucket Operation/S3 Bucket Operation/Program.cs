namespace S3_Bucket_Operation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            S3Operation s3Operation = new S3Operation();
            string LOCAL_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string OBJECT_NAME1 = "objectname1.txt";
            var path = $"{LOCAL_PATH}\\{OBJECT_NAME1}";

            //await s3Operation.UploadObjectFromFileAsync("storageudemy", "objectname1.txt", path);

            //await s3Operation.ReadObjectDataAsync("storageudemy", "objectname1.txt");

            //await s3Operation.DeleteObjectNonVersionedBucketAsync("storageudemy", "objectname1.txt");

        }
    }
}