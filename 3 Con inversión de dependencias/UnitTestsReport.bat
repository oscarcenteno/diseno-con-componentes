REM Create a 'CodeCoverageReports' folder if it does not exist
if not exist "CodeCoverageReports" mkdir "CodeCoverageReports"
 
REM Remove any previous test execution files to prevent issues overwriting
IF EXIST "CodeCoverage.trx" del "CodeCoverage.trx%"
 
REM Remove any previously created test output directories
CD %~dp0
FOR /D /R %%X IN (%USERNAME%*) DO RD /S /Q "%%X"
 
REM Run the tests against the targeted output
call :RunOpenCoverUnitTestMetrics
 
REM Generate the report output based on the test results
if %errorlevel% equ 0 (
 call :RunReportGeneratorOutput
)
 
REM Launch the report
if %errorlevel% equ 0 (
 call :RunLaunchReport
)
exit /b %errorlevel%


:RunOpenCoverUnitTestMetrics
"packages\OpenCover.4.6.519\tools\OpenCover.Console.exe" ^
-register:user ^
-target:"%VS140COMNTOOLS%\..\IDE\mstest.exe" ^
-targetargs:"/testcontainer:Negocio.UnitTests\Negocio.UnitTests\bin\Debug\Negocio.UnitTests.dll /testcontainer:BS.UnitTests\bin\Debug\BS.UnitTests.dll /testcontainer:WebApplication1.UnitTests\WebApplication1.UnitTests\bin\Debug\WebApplication1.UnitTests.dll /resultsfile:CodeCoverage.trx" ^
-filter:"+[*]*" ^
-mergebyhash ^
-skipautoprops ^
-output:"CodeCoverageReports\CodeCoverage.xml"
exit /b %errorlevel%
 
:RunReportGeneratorOutput
"packages\ReportGenerator.2.4.5.0\tools\ReportGenerator.exe" ^
-reports:"CodeCoverageReports\CodeCoverage.xml" ^
-targetdir:"CodeCoverageReports\ReportGenerator Output"
exit /b %errorlevel%
 
:RunLaunchReport
start "report" "CodeCoverageReports\ReportGenerator Output\index.htm"
exit /b %errorlevel%

PAUSE