namespace Logger.Factories
{
    using Contracts;
    using Models;
    using System;

    public class LayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            ILayout layout = null;

            switch (type)
            {
                case "SimpleLayout":
                    layout = new SimpleLayout();
                    break;
                case "XmlLayout":
                    layout = new XmlLayout();
                    break;
                default:
                    throw new ArgumentException("Invalid layout type!");
            }

            return layout;
        }
    }
}
