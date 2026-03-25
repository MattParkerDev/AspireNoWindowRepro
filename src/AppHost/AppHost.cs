
var builder = DistributedApplication.CreateBuilder(args);

// Update this with the full path to the godot executable if it is not on your PATH
var godotExecutablePath = "godot";

var godotResource = builder.AddExecutable(name: "sharpide-godot", command: godotExecutablePath, workingDirectory: ".")
	.WithOtlpExporter();

var appHost = builder.Build();

await appHost.RunAsync();
