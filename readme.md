Repro of .NET7 Isolated function app using Application Insights Dependency Tracking in Preview

Execution started but never starts executing code when line 13 in csproj file is present - <PackageReference Include="Microsoft.Azure.Functions.Worker.ApplicationInsights" Version="1.0.0-preview3" />
Which is needed for the preview feature.

With Verbose logging and executing the function:

```
Azure Functions Core Tools
Core Tools Version:       4.0.4915 Commit hash: N/A  (64-bit)
Function Runtime Version: 4.14.0.19631

[2023-02-16T21:07:39.695Z] Found C:\Users\USER\source\repos\FunctionApp14\FunctionApp14\FunctionApp14.csproj. Using for user secrets file configuration.
[2023-02-16T21:07:40.060Z] Starting Rpc Initialization Service.
[2023-02-16T21:07:40.063Z] Initializing RpcServer
[2023-02-16T21:07:40.093Z] Started AspNetCoreGrpcServer on http://127.0.0.1:61342.
[2023-02-16T21:07:40.094Z] RpcServer initialized
[2023-02-16T21:07:40.095Z] Rpc Initialization Service started.
[2023-02-16T21:07:40.099Z] Startup operation '42a6c348-28ee-4414-bcd4-9c15920ef6df' with parent id '(null)' created.
[2023-02-16T21:07:40.104Z] Startup operation '42a6c348-28ee-4414-bcd4-9c15920ef6df' starting.
[2023-02-16T21:07:40.107Z] Building host: version spec: , startup suppressed: 'False', configuration suppressed: 'False', startup operation id: '42a6c348-28ee-4414-bcd4-9c15920ef6df'
[2023-02-16T21:07:40.113Z] Host configuration applied.
[2023-02-16T21:07:40.115Z] Reading host configuration file 'C:\Users\USER\source\repos\FunctionApp14\FunctionApp14\bin\Debug\net7.0\host.json'
[2023-02-16T21:07:40.116Z] Host configuration file read:
[2023-02-16T21:07:40.117Z] {
[2023-02-16T21:07:40.117Z]   "version": "2.0",
[2023-02-16T21:07:40.118Z]   "logging": {
[2023-02-16T21:07:40.119Z]     "fileLoggingMode": "always",
[2023-02-16T21:07:40.120Z]     "logLevel": {
[2023-02-16T21:07:40.121Z]       "default": "Trace",
[2023-02-16T21:07:40.122Z]       "Host.Results": "Trace",
[2023-02-16T21:07:40.123Z]       "Function": "Trace",
[2023-02-16T21:07:40.124Z]       "Host.Aggregator": "Trace",
[2023-02-16T21:07:40.124Z]       "Microsoft": "Trace"
[2023-02-16T21:07:40.125Z]     }
[2023-02-16T21:07:40.126Z]   }
[2023-02-16T21:07:40.127Z] }
[2023-02-16T21:07:40.137Z] Workers Directory set to: C:\Users\USER\AppData\Local\AzureFunctionsTools\Releases\4.30.0\cli_x64\workers
[2023-02-16T21:07:40.143Z] Loading extensions from C:\Users\USER\source\repos\FunctionApp14\FunctionApp14\bin\Debug\net7.0. BundleConfigured: False, PrecompiledFunctionApp: False, LegacyBundle: False
[2023-02-16T21:07:40.145Z] Script Startup resetting load context with base path: 'C:\Users\USER\source\repos\FunctionApp14\FunctionApp14\bin\Debug\net7.0\.azurefunctions'.
[2023-02-16T21:07:40.155Z] Loading startup extension 'Startup'
[2023-02-16T21:07:40.219Z] Loaded extension 'Startup' (1.0.0.0)
[2023-02-16T21:07:40.240Z] IConfigurationSources registered by external startup type Microsoft.Azure.WebJobs.Extensions.FunctionMetadataLoader.Startup:
[2023-02-16T21:07:40.245Z]  Microsoft.Extensions.Configuration.Memory.MemoryConfigurationSource
[2023-02-16T21:07:40.249Z] Host configuration applied.
[2023-02-16T21:07:40.249Z] Reading host configuration file 'C:\Users\USER\source\repos\FunctionApp14\FunctionApp14\bin\Debug\net7.0\host.json'
[2023-02-16T21:07:40.251Z] Host configuration file read:
[2023-02-16T21:07:40.252Z] {
[2023-02-16T21:07:40.253Z]   "version": "2.0",
[2023-02-16T21:07:40.253Z]   "logging": {
[2023-02-16T21:07:40.255Z]     "fileLoggingMode": "always",
[2023-02-16T21:07:40.256Z]     "logLevel": {
[2023-02-16T21:07:40.257Z]       "default": "Trace",
[2023-02-16T21:07:40.258Z]       "Host.Results": "Trace",
[2023-02-16T21:07:40.259Z]       "Function": "Trace",
[2023-02-16T21:07:40.260Z]       "Host.Aggregator": "Trace",
[2023-02-16T21:07:40.261Z]       "Microsoft": "Trace"
[2023-02-16T21:07:40.262Z]     }
[2023-02-16T21:07:40.263Z]   }
[2023-02-16T21:07:40.264Z] }
[2023-02-16T21:07:40.282Z] Services registered by external startup type Microsoft.Azure.WebJobs.Extensions.FunctionMetadataLoader.Startup:
[2023-02-16T21:07:40.283Z]  Microsoft.Extensions.Options.IConfigureOptions`1[[Microsoft.Azure.WebJobs.Extensions.FunctionMetadataLoader.FunctionMetadataJsonReaderOptions, Microsoft.Azure.WebJobs.Extensions.FunctionMetadataLoader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=551316b6919f366c]]: Instance: Microsoft.Extensions.Options.ConfigureNamedOptions`1[[Microsoft.Azure.WebJobs.Extensions.FunctionMetadataLoader.FunctionMetadataJsonReaderOptions, Microsoft.Azure.WebJobs.Extensions.FunctionMetadataLoader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=551316b6919f366c]], Lifetime: Singleton
[2023-02-16T21:07:40.284Z]  Microsoft.Azure.WebJobs.Extensions.FunctionMetadataLoader.FunctionMetadataJsonReader: Implementation: Microsoft.Azure.WebJobs.Extensions.FunctionMetadataLoader.FunctionMetadataJsonReader, Lifetime: Singleton
[2023-02-16T21:07:40.284Z]  Microsoft.Azure.WebJobs.Script.Description.IFunctionProvider: Implementation: Microsoft.Azure.WebJobs.Extensions.FunctionMetadataLoader.JsonFunctionProvider, Lifetime: Singleton
[2023-02-16T21:07:40.466Z] Active host changing from '(null)' to '9289c629-a3be-40f9-a37e-48321fc0d4c2'.
[2023-02-16T21:07:40.618Z] Workers Directory set to: C:\Users\USER\AppData\Local\AzureFunctionsTools\Releases\4.30.0\cli_x64\workers
[2023-02-16T21:07:40.623Z] Found worker config: C:\Users\USER\source\repos\FunctionApp14\FunctionApp14\bin\Debug\net7.0\worker.config.json
[2023-02-16T21:07:40.634Z] EnvironmentVariable FUNCTIONS_WORKER_RUNTIME: dotnet-isolated
[2023-02-16T21:07:40.636Z] EnvironmentVariable FUNCTIONS_WORKER_RUNTIME_VERSION:
[2023-02-16T21:07:40.639Z] Added WorkerConfig for language: dotnet-isolated
[2023-02-16T21:07:40.722Z] Using BlobLeaseDistributedLockManager
[2023-02-16T21:07:40.767Z] Initializing Warmup Extension.
[2023-02-16T21:07:40.816Z] Initializing Host. OperationId: '42a6c348-28ee-4414-bcd4-9c15920ef6df'.
[2023-02-16T21:07:40.828Z] Host initialization: ConsecutiveErrors=0, StartupCount=1, OperationId=42a6c348-28ee-4414-bcd4-9c15920ef6df
[2023-02-16T21:07:40.835Z] Startup operation '42a6c348-28ee-4414-bcd4-9c15920ef6df' is starting host instance '9289c629-a3be-40f9-a37e-48321fc0d4c2'.
[2023-02-16T21:07:40.836Z] Hosting starting
[2023-02-16T21:07:40.865Z] Loading functions metadata
[2023-02-16T21:07:40.870Z] Reading functions metadata
[2023-02-16T21:07:40.872Z] Reading functions metadata
[2023-02-16T21:07:40.876Z] 0 functions found
[2023-02-16T21:07:40.878Z] 0 functions found
[2023-02-16T21:07:40.894Z] Reading functions metadata
[2023-02-16T21:07:40.956Z] 2 functions found
[2023-02-16T21:07:40.962Z] 1 functions loaded
[2023-02-16T21:07:40.968Z] LoggerFilterOptions
[2023-02-16T21:07:40.969Z] {
[2023-02-16T21:07:40.971Z]   "MinLevel": "None",
[2023-02-16T21:07:40.972Z]   "Rules": [
[2023-02-16T21:07:40.973Z]     {
[2023-02-16T21:07:40.974Z]       "ProviderName": null,
[2023-02-16T21:07:40.976Z]       "CategoryName": null,
[2023-02-16T21:07:40.977Z]       "LogLevel": null,
[2023-02-16T21:07:40.978Z]       "Filter": "<AddFilter>b__0"
[2023-02-16T21:07:40.979Z]     },
[2023-02-16T21:07:40.980Z]     {
[2023-02-16T21:07:40.980Z]       "ProviderName": null,
[2023-02-16T21:07:40.981Z]       "CategoryName": "Microsoft",
[2023-02-16T21:07:40.982Z]       "LogLevel": "Trace",
[2023-02-16T21:07:40.984Z]       "Filter": null
[2023-02-16T21:07:40.985Z]     },
[2023-02-16T21:07:40.985Z]     {
[2023-02-16T21:07:40.986Z]       "ProviderName": null,
[2023-02-16T21:07:40.987Z]       "CategoryName": "Host.Results",
[2023-02-16T21:07:40.988Z]       "LogLevel": "Trace",
[2023-02-16T21:07:40.989Z]       "Filter": null
[2023-02-16T21:07:40.990Z]     },
[2023-02-16T21:07:40.991Z]     {
[2023-02-16T21:07:40.992Z]       "ProviderName": null,
[2023-02-16T21:07:40.993Z]       "CategoryName": "Host.Aggregator",
[2023-02-16T21:07:40.994Z]       "LogLevel": "Trace",
[2023-02-16T21:07:40.995Z]       "Filter": null
[2023-02-16T21:07:40.996Z]     },
[2023-02-16T21:07:40.997Z]     {
[2023-02-16T21:07:40.998Z]       "ProviderName": null,
[2023-02-16T21:07:40.999Z]       "CategoryName": "Function",
[2023-02-16T21:07:41.000Z]       "LogLevel": "Trace",
[2023-02-16T21:07:41.000Z]       "Filter": null
[2023-02-16T21:07:41.001Z]     },
[2023-02-16T21:07:41.003Z]     {
[2023-02-16T21:07:41.004Z]       "ProviderName": null,
[2023-02-16T21:07:41.005Z]       "CategoryName": null,
[2023-02-16T21:07:41.006Z]       "LogLevel": "Trace",
[2023-02-16T21:07:41.007Z]       "Filter": null
[2023-02-16T21:07:41.008Z]     },
[2023-02-16T21:07:41.009Z]     {
[2023-02-16T21:07:41.010Z]       "ProviderName": "Microsoft.Azure.WebJobs.Script.WebHost.Diagnostics.SystemLoggerProvider",
[2023-02-16T21:07:41.012Z]       "CategoryName": null,
[2023-02-16T21:07:41.012Z]       "LogLevel": "None",
[2023-02-16T21:07:41.013Z]       "Filter": null
[2023-02-16T21:07:41.014Z]     },
[2023-02-16T21:07:41.015Z]     {
[2023-02-16T21:07:41.016Z]       "ProviderName": "Microsoft.Azure.WebJobs.Script.WebHost.Diagnostics.SystemLoggerProvider",
[2023-02-16T21:07:41.017Z]       "CategoryName": null,
[2023-02-16T21:07:41.018Z]       "LogLevel": null,
[2023-02-16T21:07:41.019Z]       "Filter": "<AddFilter>b__0"
[2023-02-16T21:07:41.021Z]     },
[2023-02-16T21:07:41.022Z]     {
[2023-02-16T21:07:41.023Z]       "ProviderName": "Azure.Functions.Cli.Diagnostics.ColoredConsoleLoggerProvider",
[2023-02-16T21:07:41.023Z]       "CategoryName": null,
[2023-02-16T21:07:41.025Z]       "LogLevel": null,
[2023-02-16T21:07:41.026Z]       "Filter": "<AddFilter>b__0"
[2023-02-16T21:07:41.027Z]     }
[2023-02-16T21:07:41.028Z]   ]
[2023-02-16T21:07:41.029Z] }
[2023-02-16T21:07:41.030Z] LoggerFilterOptions
[2023-02-16T21:07:41.031Z] {
[2023-02-16T21:07:41.032Z]   "MinLevel": "None",
[2023-02-16T21:07:41.033Z]   "Rules": [
[2023-02-16T21:07:41.033Z]     {
[2023-02-16T21:07:41.034Z]       "ProviderName": null,
[2023-02-16T21:07:41.035Z]       "CategoryName": null,
[2023-02-16T21:07:41.036Z]       "LogLevel": null,
[2023-02-16T21:07:41.037Z]       "Filter": "<AddFilter>b__0"
[2023-02-16T21:07:41.039Z]     },
[2023-02-16T21:07:41.040Z]     {
[2023-02-16T21:07:41.041Z]       "ProviderName": null,
[2023-02-16T21:07:41.042Z]       "CategoryName": "Microsoft",
[2023-02-16T21:07:41.043Z]       "LogLevel": "Trace",
[2023-02-16T21:07:41.044Z]       "Filter": null
[2023-02-16T21:07:41.045Z]     },
[2023-02-16T21:07:41.045Z]     {
[2023-02-16T21:07:41.047Z]       "ProviderName": null,
[2023-02-16T21:07:41.047Z]       "CategoryName": "Host.Results",
[2023-02-16T21:07:41.049Z]       "LogLevel": "Trace",
[2023-02-16T21:07:41.049Z]       "Filter": null
[2023-02-16T21:07:41.050Z]     },
[2023-02-16T21:07:41.051Z]     {
[2023-02-16T21:07:41.052Z]       "ProviderName": null,
[2023-02-16T21:07:41.053Z]       "CategoryName": "Host.Aggregator",
[2023-02-16T21:07:41.054Z]       "LogLevel": "Trace",
[2023-02-16T21:07:41.055Z]       "Filter": null
[2023-02-16T21:07:41.055Z]     },
[2023-02-16T21:07:41.056Z]     {
[2023-02-16T21:07:41.058Z]       "ProviderName": null,
[2023-02-16T21:07:41.059Z]       "CategoryName": "Function",
[2023-02-16T21:07:41.060Z]       "LogLevel": "Trace",
[2023-02-16T21:07:41.061Z]       "Filter": null
[2023-02-16T21:07:41.062Z]     },
[2023-02-16T21:07:41.063Z]     {
[2023-02-16T21:07:41.064Z]       "ProviderName": null,
[2023-02-16T21:07:41.065Z]       "CategoryName": null,
[2023-02-16T21:07:41.066Z]       "LogLevel": "Trace",
[2023-02-16T21:07:41.067Z]       "Filter": null
[2023-02-16T21:07:41.069Z]     },
[2023-02-16T21:07:41.070Z]     {
[2023-02-16T21:07:41.070Z]       "ProviderName": "Microsoft.Azure.WebJobs.Script.WebHost.Diagnostics.SystemLoggerProvider",
[2023-02-16T21:07:41.071Z]       "CategoryName": null,
[2023-02-16T21:07:41.072Z]       "LogLevel": "None",
[2023-02-16T21:07:41.073Z]       "Filter": null
[2023-02-16T21:07:41.074Z]     },
[2023-02-16T21:07:41.076Z]     {
[2023-02-16T21:07:41.078Z]       "ProviderName": "Microsoft.Azure.WebJobs.Script.WebHost.Diagnostics.SystemLoggerProvider",
[2023-02-16T21:07:41.079Z]       "CategoryName": null,
[2023-02-16T21:07:41.080Z]       "LogLevel": null,
[2023-02-16T21:07:41.080Z]       "Filter": "<AddFilter>b__0"
[2023-02-16T21:07:41.081Z]     },
[2023-02-16T21:07:41.082Z]     {
[2023-02-16T21:07:41.083Z]       "ProviderName": "Azure.Functions.Cli.Diagnostics.ColoredConsoleLoggerProvider",
[2023-02-16T21:07:41.083Z]       "CategoryName": null,
[2023-02-16T21:07:41.084Z]       "LogLevel": null,
[2023-02-16T21:07:41.086Z]       "Filter": "<AddFilter>b__0"
[2023-02-16T21:07:41.087Z]     }
[2023-02-16T21:07:41.088Z]   ]
[2023-02-16T21:07:41.089Z] }
[2023-02-16T21:07:41.090Z] ConcurrencyOptions
[2023-02-16T21:07:41.090Z] {
[2023-02-16T21:07:41.091Z]   "DynamicConcurrencyEnabled": false,
[2023-02-16T21:07:41.093Z]   "MaximumFunctionConcurrency": 500,
[2023-02-16T21:07:41.093Z]   "CPUThreshold": 0.8,
[2023-02-16T21:07:41.095Z]   "SnapshotPersistenceEnabled": true
[2023-02-16T21:07:41.096Z] }
[2023-02-16T21:07:41.097Z] FunctionResultAggregatorOptions
[2023-02-16T21:07:41.098Z] {
[2023-02-16T21:07:41.098Z]   "BatchSize": 1000,
[2023-02-16T21:07:41.099Z]   "FlushTimeout": "00:00:30",
[2023-02-16T21:07:41.100Z]   "IsEnabled": true
[2023-02-16T21:07:41.101Z] }
[2023-02-16T21:07:41.102Z] SingletonOptions
[2023-02-16T21:07:41.103Z] {
[2023-02-16T21:07:41.105Z]   "LockPeriod": "00:00:15",
[2023-02-16T21:07:41.107Z]   "ListenerLockPeriod": "00:00:15",
[2023-02-16T21:07:41.107Z]   "LockAcquisitionTimeout": "10675199.02:48:05.4775807",
[2023-02-16T21:07:41.109Z]   "LockAcquisitionPollingInterval": "00:00:05",
[2023-02-16T21:07:41.110Z]   "ListenerLockRecoveryPollingInterval": "00:01:00"
[2023-02-16T21:07:41.110Z] }
[2023-02-16T21:07:41.112Z] Starting JobHost
[2023-02-16T21:07:41.115Z] Starting Host (HostId=laptopj634447d-1126845224, InstanceId=9289c629-a3be-40f9-a37e-48321fc0d4c2, Version=4.14.0.19631, ProcessId=5432, AppDomainId=1, InDebugMode=False, InDiagnosticMode=False, FunctionsExtensionVersion=(null))
[2023-02-16T21:07:41.128Z] Loading functions metadata
[2023-02-16T21:07:41.130Z] Reading functions metadata
[2023-02-16T21:07:41.130Z] Reading functions metadata
[2023-02-16T21:07:41.133Z] 0 functions found
[2023-02-16T21:07:41.134Z] 0 functions found
[2023-02-16T21:07:41.135Z] Reading functions metadata
[2023-02-16T21:07:41.149Z] 2 functions found
[2023-02-16T21:07:41.150Z] 1 functions loaded
[2023-02-16T21:07:41.160Z] Adding Function descriptor provider for language dotnet-isolated.
[2023-02-16T21:07:41.163Z] Creating function descriptors.
[2023-02-16T21:07:41.185Z] Function descriptors created.
[2023-02-16T21:07:41.193Z] Placeholder mode is enabled: False
[2023-02-16T21:07:41.198Z] Generating 1 job function(s)
[2023-02-16T21:07:41.215Z] Initiating Worker Process start up
[2023-02-16T21:07:41.215Z] [channel] processing reader loop for worker dd34e645-ca3b-4ce1-9407-6cc4c820d62c:
[2023-02-16T21:07:41.220Z] Starting worker process with FileName:C:\Program Files\dotnet\dotnet.exe WorkingDirectory:C:\Users\USER\source\repos\FunctionApp14\FunctionApp14\bin\Debug\net7.0 Arguments: "C:\Users\USER\source\repos\FunctionApp14\FunctionApp14\bin\Debug\net7.0\FunctionApp14.dll" --host 127.0.0.1 --port 61342 --workerId dd34e645-ca3b-4ce1-9407-6cc4c820d62c --requestId 45e04d97-461d-4ac0-b268-0898ceaa7bed --grpcMaxMessageLength 2147483647
[2023-02-16T21:07:41.228Z] C:\Program Files\dotnet\dotnet.exe process with Id=26968 started
[2023-02-16T21:07:41.247Z] Found the following functions:
[2023-02-16T21:07:41.250Z] Host.Functions.Function1
[2023-02-16T21:07:41.252Z]
[2023-02-16T21:07:41.264Z] HttpOptions
[2023-02-16T21:07:41.265Z] {
[2023-02-16T21:07:41.266Z] Initializing function HTTP routes
[2023-02-16T21:07:41.267Z]   "DynamicThrottlesEnabled": false,
[2023-02-16T21:07:41.269Z] Mapped function route 'api/Function1' [get,post] to 'Function1'
[2023-02-16T21:07:41.270Z]   "EnableChunkedRequestBinding": false,
[2023-02-16T21:07:41.271Z]
[2023-02-16T21:07:41.272Z]   "MaxConcurrentRequests": -1,
[2023-02-16T21:07:41.273Z]   "MaxOutstandingRequests": -1,
[2023-02-16T21:07:41.274Z]   "RoutePrefix": "api"
[2023-02-16T21:07:41.277Z] }
[2023-02-16T21:07:41.285Z] Host initialized (154ms)
[2023-02-16T21:07:41.287Z] Host state changed from Default to Initialized.
[2023-02-16T21:07:41.291Z] Host started (174ms)
[2023-02-16T21:07:41.294Z] Job host started
[2023-02-16T21:07:41.298Z] File event source initialized.
[2023-02-16T21:07:41.300Z] Debug file watch initialized.
[2023-02-16T21:07:41.301Z] Diagnostic file watch initialized.
[2023-02-16T21:07:41.302Z] Hosting started
[2023-02-16T21:07:41.303Z] Host state changed from Initialized to Running.
[2023-02-16T21:07:41.305Z] Startup operation '42a6c348-28ee-4414-bcd4-9c15920ef6df' completed.

Functions:

        Function1: [GET,POST] http://localhost:7057/api/Function1

For detailed output, run func with --verbose flag.
[2023-02-16T21:07:41.382Z] Azure Functions .NET Worker (PID: 26968) initialized in debug mode. Waiting for debugger to attach...
[2023-02-16T21:07:45.175Z] Established RPC channel. WorkerId: dd34e645-ca3b-4ce1-9407-6cc4c820d62c
[2023-02-16T21:07:45.512Z] [channel] received dd34e645-ca3b-4ce1-9407-6cc4c820d62c: StartStream
[2023-02-16T21:07:45.517Z] Worker Process started. Received StartStream message[2023-02-16T21:07:45.517Z] [channel] received dd34e645-ca3b-4ce1-9407-6cc4c820d62c: RpcLog

[2023-02-16T21:07:45.524Z] [channel] received dd34e645-ca3b-4ce1-9407-6cc4c820d62c: RpcLog[2023-02-16T21:07:45.525Z] {

[2023-02-16T21:07:45.530Z] [channel] received dd34e645-ca3b-4ce1-9407-6cc4c820d62c: RpcLog
[2023-02-16T21:07:45.530Z]   "ProcessId": 26968,[2023-02-16T21:07:45.533Z] [channel] received dd34e645-ca3b-4ce1-9407-6cc4c820d62c: RpcLog

[2023-02-16T21:07:45.535Z]   "RuntimeIdentifier": "win10-x64",
[2023-02-16T21:07:45.540Z]   "WorkerVersion": "1.8.0.0",
[2023-02-16T21:07:45.542Z]   "ProductVersion": "1.8.0-local202209270007\u002B04ccbd8e45bb9017dc30ff5e1343e893a216e173",
[2023-02-16T21:07:45.543Z]   "FrameworkDescription": ".NET 7.0.2",
[2023-02-16T21:07:45.545Z]   "OSDescription": "Microsoft Windows 10.0.22621",
[2023-02-16T21:07:45.560Z]   "OSArchitecture": "X64",
[2023-02-16T21:07:45.566Z]   "CommandLine": "C:\\Users\\USER\\source\\repos\\FunctionApp14\\FunctionApp14\\bin\\Debug\\net7.0\\FunctionApp14.dll --host 127.0.0.1 --port 61342 --workerId dd34e645-ca3b-4ce1-9407-6cc4c820d62c --requestId 45e04d97-461d-4ac0-b268-0898ceaa7bed --grpcMaxMessageLength 2147483647"
[2023-02-16T21:07:45.568Z] }
[2023-02-16T21:07:45.721Z] [channel] received dd34e645-ca3b-4ce1-9407-6cc4c820d62c: WorkerInitResponse
[2023-02-16T21:07:45.723Z] Received WorkerInitResponse. Worker process initialized
[2023-02-16T21:07:45.735Z] Worker capabilities: { "RpcHttpBodyOnly": "True", "RawHttpBodyBytes": "True", "RpcHttpTriggerMetadataRemoved": "True", "UseNullableValueDictionaryForHttp": "True", "TypedDataCollection": "True", "WorkerStatus": "True", "HandlesWorkerTerminateMessage": "True" }
[2023-02-16T21:07:45.740Z] Updating capabilities: { "RpcHttpBodyOnly": "True", "RawHttpBodyBytes": "True", "RpcHttpTriggerMetadataRemoved": "True", "UseNullableValueDictionaryForHttp": "True", "TypedDataCollection": "True", "WorkerStatus": "True", "HandlesWorkerTerminateMessage": "True" }
[2023-02-16T21:07:45.743Z] Adding jobhost language worker channel for runtime: dotnet-isolated. workerId:dd34e645-ca3b-4ce1-9407-6cc4c820d62c
[2023-02-16T21:07:45.747Z] Setting up FunctionInvocationBuffer for function: 'Function1' with functionId: 'ad01cf59-90c1-457c-a8ff-2cf66e7dea00'
[2023-02-16T21:07:45.754Z] Sending FunctionLoadRequest for function:'Function1' with functionId:'ad01cf59-90c1-457c-a8ff-2cf66e7dea00'
[2023-02-16T21:07:45.768Z] Worker process started and initialized.
[2023-02-16T21:07:45.876Z] [channel] received dd34e645-ca3b-4ce1-9407-6cc4c820d62c: FunctionLoadResponse
[2023-02-16T21:07:45.878Z] Received FunctionLoadResponse for function: 'Function1' with functionId: 'ad01cf59-90c1-457c-a8ff-2cf66e7dea00'.
[2023-02-16T21:07:46.114Z] Host lock lease acquired by instance ID '0000000000000000000000003CFCD116'.
[2023-02-16T21:07:51.162Z] Executing HTTP request: {
[2023-02-16T21:07:51.167Z]   requestId: "02c0f839-577d-4fe0-870d-6bebf47ddff9",
[2023-02-16T21:07:51.170Z]   method: "GET",
[2023-02-16T21:07:51.195Z]   userAgent: "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36 Edg/110.0.1587.46",
[2023-02-16T21:07:51.205Z]   uri: "/api/Function1"
[2023-02-16T21:07:51.210Z] }
[2023-02-16T21:07:51.341Z] Request successfully matched the route with name 'Function1' and template 'api/Function1'
[2023-02-16T21:07:51.391Z] Executing 'Functions.Function1' (Reason='This function was programmatically called via the host APIs.', Id=e48087af-365d-4da1-bbe6-817f0abc9b1d)
[2023-02-16T21:07:51.402Z] Sending invocation id:e48087af-365d-4da1-bbe6-817f0abc9b1d
[2023-02-16T21:07:51.407Z] Posting invocation id:e48087af-365d-4da1-bbe6-817f0abc9b1d on workerId:dd34e645-ca3b-4ce1-9407-6cc4c820d62c
[2023-02-16T21:07:51.424Z] HttpContext has ClaimsPrincipal; parsing to gRPC.
[2023-02-16T21:07:51.432Z] Writing invocation request invocationId: e48087af-365d-4da1-bbe6-817f0abc9b1d to workerId: dd34e645-ca3b-4ce1-9407-6cc4c820d62c
```
