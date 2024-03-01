using task2;

var photoBook = new PhotoBook(16);
System.Console.WriteLine(photoBook.GetNumberPages());

var getPhoto =new BigPhotoBook(24);
System.Console.WriteLine(getPhoto.GetNumberPages());

var test = new PhotoBookTest(64);
System.Console.WriteLine(test.GetNumberPages());