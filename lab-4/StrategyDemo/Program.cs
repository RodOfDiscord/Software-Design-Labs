using ImageLightHTML;

LocalLoader localLoader = new LocalLoader();
NetworkLoader networkLoader = new NetworkLoader();

Image img = new Image("/hello.png", localLoader);
img.Display();

img.ChangeLoader(networkLoader);
img.Display();