# wix-maven

For releasing WiX into the OSS Sonatype Maven repository.  
A set of projects providing various packaging to target Maven related builds.

mvn clean  
mvn -N generate-sources -Pdownload  
mvn deploy -Pnar -Pnpanday  

## Options
### Download
-Pdownload -N  
Should be run with the -N option to only run on the aggregate build, child projects reference the download location in the parent project.
Download from Github https://github.com/wixtoolset/wix3/releases is partly automated, version in URL is not automatically updated to match mvn build.
 
### Optional NAR packaging (com.github.maven-nar::3.0.0)
-Pnar

For integration tests requires
 *  local install of msvc compiler on path
 *  running  in x86 Native Tools command prompt

### Optional npanday library packaging (org.apache.npanday::1.4.0-incubating)
-Pnpanday

For integration tests requires
 *  npanday 1.4.0-incubating requires local install of NUnit:NUnit.Framework:2.2.8.0:dll  regardless of usage in the integration tests.  
    ie.   
    mvn install:install-file -DgroupId=NUnit -DartifactId=NUnit.Framework -Dversion=2.2.8.0 -Dpackaging=library "-Dfile=C:\Program Files (x86)\NUnit 2.2.8\bin\framework\nunit.framework.dll"
 *  npanday is present in local repo, or somebody to help fix the src/it/settings.xml   custom-lifecycle is used in packaging, however maven-compile is needed for IT
 *  it002-wixca includes a NUnit test which requires nunit-console otherwise error "'nunit-console' is not recognized as an internal or external command"
 
Also works with 1.5.0-incubating-SNAPSHOT