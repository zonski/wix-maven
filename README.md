wix-maven
=========

For releasing WiX into the OSS Sonatype Maven repository
A set of projects providing various packaging to target Maven related builds.

mvn clean
mvn -N generate-sources -Pdownload
mvn deploy -Pnar -Pnpanday


## Optional NAR packaging (com.github.maven-nar)
-Pnar

For integration tests requires
 *  local install of msvc compiler on path

## Optional npanday library packaging (org.apache.npanday)
-Pnpanday

For integration tests requires
 *  npanday 1.4.0-incubating requires local install of NUnit:NUnit.Framework:2.2.8.0:dll  regardless of usage in the integration tests.
    ie. 
    mvn install:install-file -DgroupId=NUnit -DartifactId=NUnit.Framework -Dversion=2.2.8.0 -Dpackaging=library "-Dfile=C:\Program Files (x86)\NUnit 2.2.8\bin\framework\nunit.framework.dll"
