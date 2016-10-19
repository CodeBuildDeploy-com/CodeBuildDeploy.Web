CREATE TABLE [dbo].[Post]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [ShortDescription] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [Content] NVARCHAR(MAX) NOT NULL, 
    [Published] BIT NOT NULL, 
    [PostedOn] DATETIME NOT NULL, 
    [Modified] DATETIME NOT NULL,
    [Category_Id] INT NOT NULL,
    [UrlSlug] NVARCHAR(50) NOT NULL,
    CONSTRAINT [FK_Post_Category] FOREIGN KEY ([Category_Id]) REFERENCES [dbo].[Category] ([Id])
)

SET IDENTITY_INSERT [dbo].[Post] ON

INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (1, N'Libraries', N'Libraries you may like', N'This section lists libraries I often use. These range from logging frameworks to testing tools used for testing / mocking etc.', N'<ul>
    <li>Nlog</li>
        <li>Common.Logging Facade</li>
        <li>NUnit</li>
        <li>Rx</li>
</ul>', 1, N'2015-03-31 00:00:00', N'2015-03-31 00:00:00', 2, N'Libraries')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (4, N'Links', N'Useful links and resources', N'Links to External Articles / Resources.', N'<p>
    <ul>
        <li><a href="http://martinfowler.com/" target="_blank">Martin Fowler</a></li>
        <li><a href="http://www.hanselman.com/" target="_blank">Scott Hanselman</a></li>
    </ul>
</p>', 1, N'2015-03-31 00:00:00', N'2015-03-31 00:00:00', 3, N'Links')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (5, N'Tools', N'My favourite software tools', N'This section lists the tools I frequently use. Some are development tools others utility tools making general day to day working easier.', N'<p>
    <p>Ok, so everyone has their favourite tools right?.. You know when you get a new machine and 
       there''s that nice long list of tools you install on it with all the latest versions.
       Well this is my lists. Some are development tools, others just general utility tools that
       make general day to day working easier. I''m sure many of you will have differing experiences
       and additions to the list but this is my list, making my day to day working a little
       easier. Most are open source / free utilities but a few are not free but usually worth the
       premium.</p>
    <h4>General</h4>
    <ul>
        <li>
            <a href="https://justgetflux.com/" target="_blank" class="text-info">f.lux</a> - F.lux is a utility to remove blues from your screen after sunset.
        </li>
        <li>
            <a href="http://www.7-zip.org/" target="_blank" class="text-info">7Zip</a> - 7Zip for compressing and decompressing archeives.
        </li>
        <li>
            <a href="http://technet.microsoft.com/en-us/sysinternals/bb896653.aspx" target="_blank" class="text-info">Process Explorer</a> - A better Task Manager.
        </li>
        <li>
            <a href="http://www.getpaint.net/" target="_blank" class="text-info">Paint .Net</a> - A free paint and photo editing tool.
        </li>
        <li>
            <a href="https://github.com/bmatzelle/gow/wiki" target="_blank" class="text-info">GOW (Gnu on Windows)</a> - The alternative to cygwin for linux on windows.
        </li>
        <li>
            <a href="https://github.com/cmderdev/cmder" target="_blank" class="text-info">Cmder</a> - Decent Terminal on windows.
        </li>
    </ul>
    <h4>Source Control</h4>
    <ul>
        <li>
            <a href="http://www.git-scm.com/" target="_blank" class="text-info">Git</a> - Git version control system.
        </li>
        <li>
            <a href="http://code.google.com/p/tortoisegit/" target="_blank" class="text-info">Tortoise Git</a> - Port of tortoise svn for git.
        </li>
    </ul>
    <h4>Build Tools</h4>
    <ul>
        <li>
            <a href="http://www.sonarqube.org/" target="_blank" class="text-info">SonarQube</a> - Code Quality Tool.
        </li>
        <li>Maven</li>
    </ul>
    <h4>.Net development</h4>
    <ul>
        <li>Visual Studio</li>
        <li>
            <a href="http://www.jetbrains.com/resharper/" target="_blank" class="text-info">Resharper</a> - Brings Visual Studio to life.
        </li>
        <li>
            <a href="http://submain.com/products/ghostdoc.aspx" target="_blank" class="text-info">GhostDoc</a> - Automatically generates XML documentation comments for c# code.
        </li>
        <li>FxCop</li>
        <li>
            <a href="http://stylecop.codeplex.com/" target="_blank" class="text-info">StyleCop</a> - Static code analysis.
        </li>
        <li>
            <a href="http://docs.codehaus.org/display/SONAR/C%23+Plugin" target="_blank" class="text-info">SonarQube C# Plugin</a> - Publish .net projects to SonarQube.
        </li>
        <li>dotCover</li>
        <li>Open Cover</li>
        <li>Report Generator</li>
        <li>dotPeak</li>
    </ul>
</p>', 1, N'2015-03-31 00:00:00', N'2015-03-31 00:00:00', 1, N'Tools')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (6, N'PowerShell Grep', N'Grep for Windows PowerShell.', N'Need more...', N'<p>
    
</p>', 1, N'2015-05-31 00:00:00', N'2015-05-31 00:00:00', 5, N'PowerShellGrep')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (9, N'PowerShell Remoting', N'Enable and work with powershell remoting.', N'This section talks about how to enable and work with powershell remoting.', N'<p>
    <p>Windows PowerShell remoting gives you complete control over your Windows system remotely similar to the Linux Shell Terminal with SSH.
        This is extreamly useful especial when combined with configuration management tools such as Ansible. By default PowerShell remoting is disabled
        and so it must be enabled and remote machines must be granted access before it can be used. 
        
        <h3>Enabling access</h3>
        <p>Using a PowerShell session as Administrator.</p>
        <ul>
            <li>Ensure the WinRM service is running</li>
            <ul><li><code>get-service winrm</code></li></ul>
            <li>Run the WinRM service and enable PowerShell remoting</li>
            <ul><li><code>Enable-PSRemoting –force</code></li></ul>
            <li>Enable users for access</li>
            <ul><li><code>winrm s winrm/config/client ''&#64;{TrustedHosts="RemoteComputer"}''</code></li></ul>
            <li>Enable for all remote machines</li>
            <ul><li><code>Set-Item WSMan:\localhost\Client\TrustedHosts *</code></li></ul>
            <li>Restarting the WinRM service</li>
            <ul><li><code>Restart-Service winrm -Force</code></li></ul>
            <li>Checking the status of the WinRM service</li>
            <ul><li><code>winrm quickconfig</code></li></ul>
        </ul>
        
        <h3>Running commands</h3>

        <p>The Invoke-Command cmdlet is used to run a command on a remote machine. The command looks as follows: 

            <code>Invoke-Command -ComputerName COMPUTER -ScriptBlock { COMMAND } -credential USERNAME</code>
        </p>
    </p>
</p>', 1, N'2015-05-31 00:00:00', N'2015-05-31 00:00:00', 5, N'PowerShellRemoting')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) 
VALUES (7, N'Install TVHeadend', N'How to install TVHeadend.', N'How to install TVHeadend.', N'<p>
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 379CE192D401AB61<br />
echo "deb https://dl.bintray.com/tvheadend/deb vivid stable" | sudo tee -a /etc/apt/sources.list<br />
sudo apt-get update<br />
sudo apt-get install tvheadend<br />
<br />
User = XX<br />
Password = XXX<br />
<br />
To configure:<br />
<ul>
<li>Create Network</li>
<li>Set Network in adapters and enable adapters</li>
<li>Map Services (Disable all services that you dont want)</li>
<li>Enable the West York Bouquet</li>
<li>Select settings on EPG grabber</li>
<li>Now go through Channels</li>
</ul>

Test: http://host:9981/<br />
</p>', 1, N'2015-10-19 00:00:00', N'2015-10-19 00:00:00', 6, N'TVHeadend')

SET IDENTITY_INSERT [dbo].[Post] OFF