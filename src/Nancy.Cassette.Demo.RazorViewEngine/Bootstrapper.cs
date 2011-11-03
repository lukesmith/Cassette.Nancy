﻿namespace Nancy.Cassette.Demo.RazorViewEngine
{
  public class Bootstrapper : DefaultNancyBootstrapper
  {
    protected override void ApplicationStartup(TinyIoC.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
    {
      base.ApplicationStartup(container, pipelines);

      Nancy.Cassette.Hooks.Install(container, pipelines);
    }

  }
}