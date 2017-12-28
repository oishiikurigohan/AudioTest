using System;
using CocosSharp;
using Xamarin.Forms;

namespace AudioTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            this.CocosView.ViewCreated += (sender, e) =>
            {
                var gameView = sender as CCGameView;
                var scene = new CCScene(gameView);
                var layer = new CCLayerColor();
                scene.AddLayer(layer);

                var background = new CCSprite("background", null);
                background.Position = layer.VisibleBoundsWorldspace.Center;
                layer.AddChild(background);

                var kurineko = new CCSprite("kurineko", null);
                kurineko.Position = layer.VisibleBoundsWorldspace.Center;
                layer.AddChild(kurineko);

                gameView.RunWithScene(scene);
            };
        }

        public void Meow(object sender, EventArgs e)
        {
            CCAudioEngine.SharedEngine.PlayEffect("meow");
        }
    }
}
