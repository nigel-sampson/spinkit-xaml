Spinkit.Xaml
============

A port of a collection of styles for the Windows 8 Progress Ring control, inspired by the CSS [SpinKit][sk] by [Tobias Ahlin][ta]. Demo video available on [Youtube: Spinkit Xaml demo][yt].

Usage
-----

Install the nuget package:

```PowerShell
Install-Package Spinkit.Xaml
```

Which will import the **Spinkit.Styles.xaml** resource dictionary into your projects. You can then import this dictionary in your *App.xaml*.

```Xml
<Application.Resources>
  <ResourceDictionary>
    <ResourceDictionary.MergedDictionaries>
      <ResourceDictionary Source="Spinkit.Styles.xaml" />
    </ResourceDictionary.MergedDictionaries>
  </ResourceDictionary>
</Application.Resources>
```

You can then mark up your Progress Ring controls with the new styles.

```Xmal
<ProgressRing IsActive="True" Style="{StaticResource RotatingPlaneProgressRingStyle}" />
```

Check out the sample app in this repository to browse all the available styles.

[sk]: http://tobiasahlin.com/spinkit/
[ta]: https://twitter.com/tobiasahlin
[yt]: http://www.youtube.com/watch?v=Lr5EulwTYz0
