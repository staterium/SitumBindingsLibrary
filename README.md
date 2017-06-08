# SitumBindingsLibrary

A Xamarin Bindings Library for the Situm SDK. 

www.situm.es

This project provides a prototype Xamarin Bindings Library for use with the Situm SDK.

The root project is SitumLib, which compiles SitumLib.dll for use in Xamarin projects.

The additional projects (BeaconLib, ProtobufLib etc.) builds Xamarin Bindings Libraries for the JAR and AAR dependencies on which Situm relies. The SitumLib project references these additional projects.

