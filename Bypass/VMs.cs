using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bypass
{
    public class VMs
    {
        public class VirtualBox
        {
            public static void Patch()
            {
                PatchIDE();
                PatchVGA();
                PatchBios();
            }
            private static void PatchIDE()
            {
                BetterRegEdit.Search_Edit(@"SYSTEM\ControlSet001\Enum\IDE\", "FriendlyName");
                BetterRegEdit.Search_Edit(@"SYSTEM\ControlSet002\Enum\IDE\", "FriendlyName");

            }
            private static void PatchVGA()
            {
                BetterRegEdit.Search_Edit(@"SYSTEM\ControlSet002\Enum\PCI\", "DeviceDesc");
                BetterRegEdit.Search_Edit(@"SYSTEM\CurrentControlSet\Enum\PCI\", "DeviceDesc");
                BetterRegEdit.Search_Edit(@"SYSTEM\ControlSet002\Services\", "Device Description");
                BetterRegEdit.Search_Edit(@"SYSTEM\CurrentControlSet\Control\Class\", "DriverDesc");
                BetterRegEdit.Search_Edit(@"SYSTEM\CurrentControlSet\Control\Video\", "Device Description");
                BetterRegEdit.Search_Edit(@"SYSTEM\CurrentControlSet\Services\", "Device Description");
            }
            private static void PatchBios()
            {
                BetterRegEdit.DeleteRegistry(@"HARDWARE\ACPI\DSDT\VBOX__");
                BetterRegEdit.EditRegistry(@"HARDWARE\DESCRIPTION\SYSTEM", "SystemBiosVersion", "RegWin32");
                BetterRegEdit.EditRegistry(@"HARDWARE\DESCRIPTION\SYSTEM", "VideoBiosVersion", "RegWin64");
            }
        }
        public class VMWare_10
        {
            private static void PatchMouse()
            {
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Services\vmmouse", "DisplayName", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\DriverDatabase\DriverPackages\vmmouse.inf_amd64_0d7f7b181689e533\Strings", "vmmouse.svcdesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\DriverDatabase\DriverPackages\vmusbmouse.inf_amd64_8ce2be7e80ba2487\Strings", "vmusbmouse.svcdesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4d36e96f-e325-11ce-bfc1-08002be10318}\0000", "DriverDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4d36e96f-e325-11ce-bfc1-08002be10318}\0001", "DriverDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4d36e96f-e325-11ce-bfc1-08002be10318}\0002", "DriverDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\HID\VID_0E0F&PID_0003&MI_00\8&1230c469&0&0000", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\HID\VID_0E0F&PID_0003&MI_01\8&3608022b&0&0000", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e96f-e325-11ce-bfc1-08002be10318}\0001", "DriverDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e96f-e325-11ce-bfc1-08002be10318}\0002", "DriverDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\HID\VID_0E0F&PID_0003&MI_00\8&1230c469&0&0000", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\HID\VID_0E0F&PID_0003&MI_01\8&3608022b&0&0000", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\DriverDatabase\DriverPackages\vmusbmouse.inf_amd64_8ce2be7e80ba2487\Strings", "vmusbmouse.svcdesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\ACPI\VMW0003\4&1bd7f811&0", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\ACPI\VMW0003\4&1bd7f811&0", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\DriverDatabase\DriverPackages\vmmouse.inf_x86_6d8a35d0ee24b945\Strings", "vmmouse.svcdesc", "RegWin32 Mouse");
            }
            private static void PatchSCI()
            {
                RegEdit.DeleteRegistry(@"SYSTEM\CurrentControlSet\Enum\SCSI");
                RegEdit.DeleteRegistry(@"SYSTEM\ControlSet001\Enum\SCSI\");
                RegEdit.DeleteRegistry(@"SYSTEM\CurrentControlSet\Enum\SCSI");
            }
            private static void PatchVGA()
            {
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "HardwareInformation.ChipType", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "HardwareInformation.ChipType", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "HardwareInformation.ChipType", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "HardwareInformation.ChipType", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "HardwareInformation.ChipType", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "HardwareInformation.ChipType", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "HardwareInformation.ChipType", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "HardwareInformation.ChipType", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "HardwareInformation.ChipType", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "DriverDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "DriverDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "DriverDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "DriverDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "DriverDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "DriverDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "DriverDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "DriverDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&61aaa01&0&78", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&61aaa01&0&78", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "DriverDesc", "RegWin32 Nvidia 5000");
            }
            private static void UnpatchVGA()
            {
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "Device Description", "VMWare SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "HardwareInformation.ChipType", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "HardwareInformation.ChipType", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "HardwareInformation.ChipType", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "HardwareInformation.ChipType", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "HardwareInformation.ChipType", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "HardwareInformation.ChipType", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "HardwareInformation.ChipType", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "HardwareInformation.ChipType", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "HardwareInformation.ChipType", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "DriverDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "DriverDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "DriverDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "DriverDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "DriverDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "DriverDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "DriverDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "DriverDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&61aaa01&0&78", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0000", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0001", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0002", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0003", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0004", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0005", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0006", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{309FC7B3-A522-437E-AF43-B25DAF262E56}\0007", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&61aaa01&0&78", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "DriverDesc", "VMware SVGA 3D");
            }
            private static void PatchVMCI()
            {
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4d36e97d-e325-11ce-bfc1-08002be10318}\0133", "DriverDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\PCI\VEN_15AD&DEV_0740&SUBSYS_074015AD&REV_10\3&61aaa01&0&3F", "DriverDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\ROOT\VMWVMCIHOSTDEV\0000", "DeviceDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e97d-e325-11ce-bfc1-08002be10318}\0133", "DriverDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\PCI\VEN_15AD&DEV_0740&SUBSYS_074015AD&REV_10\3&61aaa01&0&3F", "DeviceDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\ROOT\VMWVMCIHOSTDEV\0000", "DeviceDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\DriverDatabase\DriverPackages\vmci.inf_amd64_faff95b55e0fdc1f\Strings", "vmware.devicedesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\DriverDatabase\DriverPackages\vmci.inf_amd64_faff95b55e0fdc1f\Strings", "vmwarehost.devicedesc", "RegWin32 VMCI Bus Device");
            }
            public static void WIN_10_Patch()
            {
                PatchMouse();
                PatchSCI();
                PatchVGA();
                PatchVMCI();
            }
            public static void WIN_10_Unpatch()
            {
                UnpatchVGA();
            }
        }
        public class VMWare_7
        {
            public static void WIN_7_Patch()
            {
                PatchVGA();
                PatchHDD();
                PatchMouse();
                PatchBUS();
                PatchSATA();
            }
            public static void WIN_7_Unpatch()
            {
                UnPatchVGA();
            }
            private static void UnPatchVGA()
            {
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "HardwareInformation.ChipType", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000\Settings", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0000", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0000", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0000\Settings", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0001", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0001", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0001\Settings", "Device Description", "VMware Inc Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0002", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0002", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003\Settings", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004\Settings", "Device Description", "VMware Inc Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005\Settings", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006\Settings", "Device Description", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007\Settings", "Device Description", "VMware Inc Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&2b8e0b4b&0&78", "DeviceDesc", "VMware Inc Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\services\vm3dmp\Device0", "Device Description", "VMware Inc Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "Device Description", "VMware Inc Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "HardwareInformation.AdapterString", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000\Settings", "Device Description", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&2b8e0b4b&0&78", "DeviceDesc", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0002", "HardwareInformation.AdapterString", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0002", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0002\Settings", "Device Description", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003", "HardwareInformation.AdapterString", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003\Settings", "Device Description", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004", "HardwareInformation.AdapterString", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004\Settings", "Device Description", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005", "HardwareInformation.AdapterString", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005\Settings", "Device Description", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006", "HardwareInformation.AdapterString", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006\Settings", "Device Description", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007", "HardwareInformation.AdapterString", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007", "HardwareInformation.ChipType", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007\Settings", "Device Description", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\services\vm3dmp\Device0", "Device Description", "VMware Inc");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&2b8e0b4b&0&78", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&2b8e0b4b&0&78", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&2b8e0b4b&0&78", "DeviceDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "DriverDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "DriverDesc", "VMware SVGA 3D");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\services\vm3dmp\Device0", "Device Description", "VMware SVGA 3D");
            }
            private static void PatchVGA()
            {
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000\Settings", "Device Description", "RegWin32 Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0000", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0000", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0000\Settings", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0001", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0001", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0001\Settings", "Device Description", "RegWin32 Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0002", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0002", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003\Settings", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004\Settings", "Device Description", "RegWin32 Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005\Settings", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006\Settings", "Device Description", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007\Settings", "Device Description", "RegWin32 Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&2b8e0b4b&0&78", "DeviceDesc", "RegWin32 Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\services\vm3dmp\Device0", "Device Description", "RegWin32 Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "Device Description", "RegWin32 Nivida 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "HardwareInformation.AdapterString", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000\Settings", "Device Description", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&2b8e0b4b&0&78", "DeviceDesc", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0002", "HardwareInformation.AdapterString", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0002", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0002\Settings", "Device Description", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003", "HardwareInformation.AdapterString", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0003\Settings", "Device Description", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004", "HardwareInformation.AdapterString", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0004\Settings", "Device Description", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005", "HardwareInformation.AdapterString", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0005\Settings", "Device Description", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006", "HardwareInformation.AdapterString", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0006\Settings", "Device Description", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007", "HardwareInformation.AdapterString", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007", "HardwareInformation.ChipType", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Video\{2C932A28-C0F0-406E-AA38-15220D079E69}\0007\Settings", "Device Description", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\services\vm3dmp\Device0", "Device Description", "RegWin32");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&2b8e0b4b&0&78", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&2b8e0b4b&0&78", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&2b8e0b4b&0&78", "DeviceDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "DriverDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "DriverDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\services\vm3dmp\Device0", "Device Description", "RegWin32 Nvidia 5000");
            }
            private static void PatchHDD()
            {
                RegEdit.DeleteRegistry(@"HARDWARE\DEVICEMAP\Scsi\Scsi Port 2\Scsi Bus 0\Target Id 0\Logical Unit Id 0");
                RegEdit.DeleteRegistry(@"SYSTEM\ControlSet001\Enum\SCSI\Disk&Ven_VMware_&Prod_VMware_Virtual_S\5&22be343f&0&000000");
                RegEdit.DeleteRegistry(@"SYSTEM\ControlSet002\Enum\SCSI\Disk&Ven_VMware_&Prod_VMware_Virtual_S\5&22be343f&0&000000");
                RegEdit.DeleteRegistry(@"SYSTEM\CurrentControlSet\Enum\SCSI\Disk&Ven_VMware_&Prod_VMware_Virtual_S\5&22be343f&0&000000");
            }
            private static void PatchMouse()
            {
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E96F-E325-11CE-BFC1-08002BE10318}\0000", "DriverDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\ACPI\VMW0003\4&205ad762&0", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Class\{4D36E96F-E325-11CE-BFC1-08002BE10318}\0000", "DriverDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\ACPI\VMW0003\4&205ad762&0", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\HID\VID_0E0F&PID_0003&MI_00\8&17be0303&0&0000", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\HID\VID_0E0F&PID_0003&MI_01\8&2f818f48&0&0000", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\services\vmusbmouse", "DisplayName", "RegWin32 Mouse");
            }
            private static void PatchBUS()
            {
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E97D-E325-11CE-BFC1-08002BE10318}\0132", "DriverDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Class\{4D36E97D-E325-11CE-BFC1-08002BE10318}\0132", "DriverDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\PCI\VEN_15AD&DEV_0740&SUBSYS_074015AD&REV_10\3&2b8e0b4b&0&3F", "DeviceDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E97D-E325-11CE-BFC1-08002BE10318}\0132", "DeviceDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Enum\PCI\VEN_15AD&DEV_0740&SUBSYS_074015AD&REV_10\3&2b8e0b4b&0&3F", "DeviceDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\PCI\VEN_15AD&DEV_0740&SUBSYS_074015AD&REV_10\3&2b8e0b4b&0&3F", "DeviceDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\services\vmciF", "DisplayName", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\services\vmci", "DisplayName", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\services\vmci", "DisplayName", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\Root\VMWVMCIHOSTDEV\0000", "DeviceDesc", "RegWin32 VMCI Host Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Enum\Root\VMWVMCIHOSTDEV\0000", "DeviceDesc", "RegWin32 VMCI Host Device");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\Root\VMWVMCIHOSTDEV\0000", "DeviceDesc", "RegWin32 VMCI Host Device");
                RegEdit.EditRegistry(@"CurrentControlSet\Enum\Root\VMWVMCIHOSTDEV\0000", "DeviceDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E97D-E325-11CE-BFC1-08002BE10318}\0132", "DriverDesc", "RegWin32 VMCI Host Device");
            }
            private static void PatchSATA()
            {
                RegEdit.DeleteRegistry(@"SYSTEM\ControlSet001\Enum\IDE");
            }
        }
        public class VMWare_XP
        {
            private static void PatchVGA()
            {
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E968-E325-11CE-BFC1-08002BE10318}\0000", "DriverDesc", "RegWin32 Nvidia 5000");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\PCI\VEN_15AD&DEV_0405&SUBSYS_040515AD&REV_00\3&61aaa01&0&78", "DeviceDesc", "RegWin32 NVIDIA 5000");
            }
            private static void PatchSATA()
            {
                RegEdit.DeleteRegistry(@"SYSTEM\ControlSet002\Enum\IDE");
                RegEdit.DeleteRegistry(@"SYSTEM\ControlSet001\Enum\IDE");
            }
            private static void PatchMouse()
            {
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E96F-E325-11CE-BFC1-08002BE10318}\0000", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E96F-E325-11CE-BFC1-08002BE10318}\0000", "DriverDesc", "RegWin32 USB Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E96F-E325-11CE-BFC1-08002BE10318}\0002", "DriverDesc", "RegWin32 USB Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E96F-E325-11CE-BFC1-08002BE10318}\0003", "DriverDesc", "RegWin32 USB Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E96F-E325-11CE-BFC1-08002BE10318}\0003", "DriverDesc", "RegWin32 USB Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Services\vmusbmouse", "DisplayName", "RegWin32 USB Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\HID\Vid_0e0f&Pid_0003&MI_00\8&28f6544d&0&0000", "DeviceDesc", "RegWin32 USB Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\HID\Vid_0e0f&Pid_0003&MI_01\8&51f168b&0&0000", "DeviceDesc", "RegWin32 USB Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\ACPI\VMW0003\4&5289e18&0", "DeviceDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Services\vmmouse", "DisplayName", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Services\vmusbmouse", "DisplayName", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E96F-E325-11CE-BFC1-08002BE10318}\0000", "DriverDesc", "RegWin32 Mouse");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Enum\ACPI\VMW0003\4&5289e18&0", "DriverDesc", "RegWin32 Mouse");
            }
            private static void PatchNet()
            {
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\PCI\VEN_1022&DEV_2000&SUBSYS_20001022&REV_10\4&47b7341&0&0888", "DeviceDesc", "RegWin32 PCNet Adapter");
            }
            private static void PatchVMCI()
            {
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E97D-E325-11CE-BFC1-08002BE10318}\0058", "DriverDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Control\Class\{4D36E97D-E325-11CE-BFC1-08002BE10318}\0059", "DriverDesc", "RegWin32 VMCI Host Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E97D-E325-11CE-BFC1-08002BE10318}\0059", "DriverDesc", "RegWin32 VMCI Host Device");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Control\Class\{4D36E97D-E325-11CE-BFC1-08002BE10318}\0059", "DriverDesc", "RegWin32 VMCI Host Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\PCI\VEN_15AD & DEV_0740 & SUBSYS_074015AD & REV_10\3 & 61aaa01 & 0 & 3F", "DeviceDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Enum\Root\VMWVMCIHOSTDEV\0000", "DeviceDesc", "RegWin32 VMCI Host Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Enum\Root\VMWVMCIHOSTDEV\0000", "DeviceDesc", "RegWin32 VMCI Host Device");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\Root\VMWVMCIHOSTDEV\0000", "DeviceDesc", "RegWin32 VMCI Host Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Enum\PCI\VEN_15AD&DEV_0740&SUBSYS_074015AD&REV_10\3&61aaa01&0&3F", "DeviceDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\CurrentControlSet\Enum\PCI\VEN_15AD&DEV_0740&SUBSYS_074015AD&REV_10\3&61aaa01&0&3F", "DeviceDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Control\Class\{4D36E97D-E325-11CE-BFC1-08002BE10318}\0058", "DriverDesc", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet001\Services\vmci", "DisplayName", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"SYSTEM\ControlSet002\Services\vmci", "DisplayName", "RegWin32 VMCI Bus Device");
                RegEdit.EditRegistry(@"CurrentControlSet\Services\vmci", "DisplayName", "RegWin32 VMCI Bus Device");
            }
            public static void WIN_XP_Patch()
            {
                PatchVGA();
                PatchSATA();
                PatchMouse();
                PatchNet();
                PatchVMCI();
            }
        }
    }
}
