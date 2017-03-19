using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using testspace;

namespace VWxml
{
    public class Test
    {
        public void generateXml()
        {
            Category lamps = new Category
            {
                Name = "Lamps",
                Alias = "UIRESOURCE:Lamps",

                Property = new CategoryProperty
                {
                    Name = "Visible",
                    Type = "Boolean",
                    Value = "True"
                },

                Category1 = new CategoryCategory
                {
                    Name = "LPCeiling",
                    Alias = "UIRESOURCE:LPCeiling",
                }
            };

            CategoryCategoryCategory parent1 = new CategoryCategoryCategory
            {
                Name = "LP_Snowball_parent",
                Alias = "UIRESOURCE:LP_Snowball",
                Property = new CategoryCategoryCategoryProperty[] {
                    new CategoryCategoryCategoryProperty
                    {
                        Name = "LibraryImage",
                        Type = "String",
                        Value = "/libraries/sismodules/image/LP_snowball.png"
                    },
                    new CategoryCategoryCategoryProperty
                        {
                        Name = "Type",
                        Type = "String",
                        Value = "LampParent"
                    },
                    new CategoryCategoryCategoryProperty
                    {
                        Name = "ULClass",
                        Type = "String",
                        Value = "LampParent"
                    }
                }
            };

            CategoryCategoryCategoryCategory lamp1Sizes = new CategoryCategoryCategoryCategory
            {
                Name = "LP_Snowball_Sizes",
                Alias = "UIRESOURCE:LP_Lamp_Sizes",
                Property = new CategoryCategoryCategoryCategoryProperty[]
                {
                    new CategoryCategoryCategoryCategoryProperty
                    {
                        Name = "Type",
                        Type = "String",
                        Value = "LampSizes"
                    },
                    new CategoryCategoryCategoryCategoryProperty
                    {
                        Name = "ULClass",
                        Type = "String",
                        Value = "LampSizes"
                    },
                },
                PartItem = new CategoryCategoryCategoryCategoryPartItem[]
                {
                    new CategoryCategoryCategoryCategoryPartItem
                    {
                        Name = "LP_Snowball_s",
                        Alias = "UIRESOURCE:LP_Snowball_s",
                        Property = new CategoryCategoryCategoryCategoryPartItemProperty[]
                        {
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "SizeSelection",
                                Type = "String",
                                Value1 = "s"
                            },
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "MultiExtends",
                                Type = "Array",
                                Value1 = "SizeOption"
                            }
                        }
                    },
                    new CategoryCategoryCategoryCategoryPartItem
                    {
                        Name = "LP_Snowball_m",
                        Alias = "UIRESOURCE:LP_Snowball_m",
                        Property = new CategoryCategoryCategoryCategoryPartItemProperty[]
                        {
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "SizeSelection",
                                Type = "String",
                                Value1 = "m"
                            },
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "MultiExtends",
                                Type = "Array",
                                Value1 = "SizeOption"
                            }
                        }
                    },
                    new CategoryCategoryCategoryCategoryPartItem
                    {
                        Name = "LP_Snowball_l",
                        Alias = "UIRESOURCE:LP_Snowball_l",
                        Property = new CategoryCategoryCategoryCategoryPartItemProperty[]
                        {
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "SizeSelection",
                                Type = "String",
                                Value1 = "l"
                            },
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "MultiExtends",
                                Type = "Array",
                                Value1 = "SizeOption"
                            }
                        }
                    },
                }
            };

            CategoryCategoryCategoryCategory lamp1Colours = new CategoryCategoryCategoryCategory()
            {
                Name = "LP_Snowball_Colours",
                Alias = "UIRESOURCE:LP_Lamp_Colours",
                Property = new CategoryCategoryCategoryCategoryProperty[]
                {
                    new CategoryCategoryCategoryCategoryProperty
                    {
                        Name = "Type",
                        Type = "String",
                        Value = "LampColour"
                    },
                    new CategoryCategoryCategoryCategoryProperty
                    {
                        Name = "ULClass",
                        Type = "String",
                        Value = "lib-icons LampColour"
                    }
                },
                PartItem = new CategoryCategoryCategoryCategoryPartItem[]
                {
                    new CategoryCategoryCategoryCategoryPartItem
                    {
                        Name = "LP_Snowball",
                        Property = new CategoryCategoryCategoryCategoryPartItemProperty[]
                        {
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "MultiExtends",
                                Type = "Array",
                                Value = new String[]
                                {
                                    "Generic_Part",
                                    "CeilingLamp"
                                }
                            },
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "SizeProperty",
                                Type = "String",
                                Value1 = "s"
                            },
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "Alias",
                                Type = "String",
                                Value1 = "UIRESOURCE:Snowball"
                            },
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "Size",
                                Type = "Size3",
                                Value1 ="40.1 70.9 40.1"
                            },
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "LibraryImage",
                                Type = "String",
                                Value1 = "/libraries/sismodules/image/LP_snowball.png"
                            },
                            new CategoryCategoryCategoryCategoryPartItemProperty
                            {
                                Name = "Template",
                                Type = "String",
                                Value1 = "LP_Snowball"
                            },
                        },
                        SlotGroup = new CategoryCategoryCategoryCategoryPartItemSlotGroup[]
                        {
                            new CategoryCategoryCategoryCategoryPartItemSlotGroup
                            {
                                Name = "MaterialSlots",
                                Property = new CategoryCategoryCategoryCategoryPartItemSlotGroupProperty[]
                                {
                                    new CategoryCategoryCategoryCategoryPartItemSlotGroupProperty
                                    {
                                        Name = "Type",
                                        Type = "String",
                                        Value = "Undefined"
                                    },
                                },
                                Slot = new CategoryCategoryCategoryCategoryPartItemSlotGroupSlot[]
                                {
                                    new CategoryCategoryCategoryCategoryPartItemSlotGroupSlot
                                    {
                                        Name = "metal_chromeMAT",
                                        Property = new CategoryCategoryCategoryCategoryPartItemSlotGroupSlotProperty[]
                                        {
                                            new CategoryCategoryCategoryCategoryPartItemSlotGroupSlotProperty
                                            {
                                                Name = "MaterialName",
                                                Type = "String",
                                                Value = "metal_chromeMAT"
                                            }
                                        }
                                    },
                                    new CategoryCategoryCategoryCategoryPartItemSlotGroupSlot
                                    {
                                        Name = "snowball_plastic_whiteMAT",
                                        Property = new CategoryCategoryCategoryCategoryPartItemSlotGroupSlotProperty[]
                                        {
                                            new CategoryCategoryCategoryCategoryPartItemSlotGroupSlotProperty
                                            {
                                                Name = "MaterialName",
                                                Type = "String",
                                                Value = "snowball_plastic_whiteMAT"
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            parent1.Category = new CategoryCategoryCategoryCategory[]
            {
                lamp1Sizes,
                lamp1Colours
            };

            lamps.Category1.Category = new CategoryCategoryCategory[] {
                parent1
            };

            XmlSerializer ser = new XmlSerializer(typeof(Category));

            TextWriter writer = new StreamWriter("test_output.xml");
            ser.Serialize(writer, lamps);
            writer.Close();
        }
    }
}