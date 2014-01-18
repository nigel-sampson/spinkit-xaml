This package will import the Spinkit.Styles.xaml resource dictionary into your projects. You can then import this dictionary in your App.xaml.

<Application.Resources>
  <ResourceDictionary>
    <ResourceDictionary.MergedDictionaries>
      <ResourceDictionary Source="Spinkit.Styles.xaml" />
    </ResourceDictionary.MergedDictionaries>
  </ResourceDictionary>
</Application.Resources>

You can then mark up your Progress Ring controls with the new styles.

<ProgressRing IsActive="True" Style="{StaticResource RotatingPlaneProgressRingStyle}" />

Check out the sample app at https://github.com/nigel-sampson/spinkit-xaml to browse all the available styles.