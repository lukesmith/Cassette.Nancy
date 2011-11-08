﻿using Nancy.Conventions;
using Utility.Logging.NLog;

namespace Nancy.Cassette.Demo.RazorViewEngine
{
  public class Bootstrapper : DefaultNancyBootstrapper
  {
    public Bootstrapper()
    {
      //CassetteStartup.ShouldOptimizeOutput = true;
      CassetteStartup.Logger = new NLogLoggerFactory().GetCurrentClassLogger();
    }

    protected override void ApplicationStartup(TinyIoC.TinyIoCContainer container, global::Nancy.Bootstrapper.IPipelines pipelines)
    {
      base.ApplicationStartup(container, pipelines);
      
      Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Images"));
    }
  }
}