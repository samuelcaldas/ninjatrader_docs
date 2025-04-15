#region Using declarations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
using NinjaTrader.Cbi;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Gui.Tools;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.NinjaScript.Indicators;
using NinjaTrader.NinjaScript.DrawingTools;
#endregion

//This namespace holds Strategies in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.Strategies
{
	public class SampleIsFallingIsRising : Strategy
	{
		private ADX ADX1;
		private SMA SMA1;

		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description									= @"This sample demonstrates the use of the IsRising and IsFalling conditions within the Strategy Builder.";
				Name										= "SampleIsFallingIsRising";
				Calculate									= Calculate.OnBarClose;
				EntriesPerDirection							= 1;
				EntryHandling								= EntryHandling.AllEntries;
				IsExitOnSessionCloseStrategy				= true;
				ExitOnSessionCloseSeconds					= 30;
				IsFillLimitOnTouch							= false;
				MaximumBarsLookBack							= MaximumBarsLookBack.TwoHundredFiftySix;
				OrderFillResolution							= OrderFillResolution.Standard;
				Slippage									= 0;
				StartBehavior								= StartBehavior.WaitUntilFlat;
				TimeInForce									= TimeInForce.Gtc;
				TraceOrders									= false;
				RealtimeErrorHandling						= RealtimeErrorHandling.StopCancelClose;
				StopTargetHandling							= StopTargetHandling.PerEntryExecution;
				BarsRequiredToTrade							= 20;
				// Disable this property for performance gains in Strategy Analyzer optimizations
				// See the Help Guide for additional information
				IsInstantiatedOnEachOptimizationIteration	= true;
				ADXPeriod					= 14;
				SMAPeriod					= 14;
			}
			else if (State == State.Configure)
			{
			}
			else if (State == State.DataLoaded)
			{				
				ADX1				= ADX(Close, Convert.ToInt32(ADXPeriod));
				ADX1.Plots[0].Brush = Brushes.DarkCyan;
				AddChartIndicator(ADX1);
				SMA1				= SMA(Close, Convert.ToInt32(SMAPeriod));
				SMA1.Plots[0].Brush = Brushes.Goldenrod;
				AddChartIndicator(SMA1);
				ADX1				= ADX(Close, Convert.ToInt32(ADXPeriod));
			}
		}

		protected override void OnBarUpdate()
		{
			if (BarsInProgress != 0) 
				return;

			if (CurrentBars[0] < 1)
			return;

			 // Set 1
			if ((IsRising(ADX1) == true)
				 && (IsFalling(SMA1) == true))
			{
				EnterLong(Convert.ToInt32(DefaultQuantity), "");
			}
			
			 // Set 2
			if (IsFalling(ADX1) == true)
			{
				ExitLong(Convert.ToInt32(DefaultQuantity), "", "");
			}
			
		}

		#region Properties
		[NinjaScriptProperty]
		[Range(1, int.MaxValue)]
		[Display(Name="ADXPeriod", Order=1, GroupName="Parameters")]
		public int ADXPeriod
		{ get; set; }

		[NinjaScriptProperty]
		[Range(1, int.MaxValue)]
		[Display(Name="SMAPeriod", Order=2, GroupName="Parameters")]
		public int SMAPeriod
		{ get; set; }
		#endregion

	}
}

#region Wizard settings, neither change nor remove
/*@
<?xml version="1.0"?>
<ScriptProperties xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <Calculate>OnBarClose</Calculate>
  <ConditionalActions>
    <ConditionalAction>
      <Actions>
        <WizardAction>
          <IsExpanded>false</IsExpanded>
          <IsSelected>true</IsSelected>
          <Name>Enter long position</Name>
          <Offset>
            <IsSetEnabled>false</IsSetEnabled>
            <OffsetValue>0</OffsetValue>
            <OffsetOperator>Add</OffsetOperator>
            <OffsetType>Arithmetic</OffsetType>
          </Offset>
          <OffsetType>Arithmetic</OffsetType>
          <ActionProperties>
            <Anchor1BarsAgo>0</Anchor1BarsAgo>
            <Anchor1Y>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Anchor1Y>
            <Anchor2BarsAgo>0</Anchor2BarsAgo>
            <Anchor2Y>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Anchor2Y>
            <Anchor3BarsAgo>0</Anchor3BarsAgo>
            <Anchor3Y>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Anchor3Y>
            <AreaBrush xsi:type="SolidColorBrush">
              <Opacity>1</Opacity>
              <Transform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </Transform>
              <RelativeTransform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </RelativeTransform>
              <Color>
                <A>255</A>
                <R>100</R>
                <G>149</G>
                <B>237</B>
                <ScA>1</ScA>
                <ScR>0.127437681</ScR>
                <ScG>0.3005438</ScG>
                <ScB>0.8468732</ScB>
              </Color>
            </AreaBrush>
            <AreaOpacity>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </AreaOpacity>
            <BackBrush xsi:type="SolidColorBrush">
              <Opacity>1</Opacity>
              <Transform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </Transform>
              <RelativeTransform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </RelativeTransform>
              <Color>
                <A>255</A>
                <R>100</R>
                <G>149</G>
                <B>237</B>
                <ScA>1</ScA>
                <ScR>0.127437681</ScR>
                <ScG>0.3005438</ScG>
                <ScB>0.8468732</ScB>
              </Color>
            </BackBrush>
            <BarsAgo>0</BarsAgo>
            <Brush xsi:type="SolidColorBrush">
              <Opacity>1</Opacity>
              <Transform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </Transform>
              <RelativeTransform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </RelativeTransform>
              <Color>
                <A>255</A>
                <R>100</R>
                <G>149</G>
                <B>237</B>
                <ScA>1</ScA>
                <ScR>0.127437681</ScR>
                <ScG>0.3005438</ScG>
                <ScB>0.8468732</ScB>
              </Color>
            </Brush>
            <Color>
              <A>255</A>
              <R>100</R>
              <G>149</G>
              <B>237</B>
              <ScA>1</ScA>
              <ScR>0.127437681</ScR>
              <ScG>0.3005438</ScG>
              <ScB>0.8468732</ScB>
            </Color>
            <Currency>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Currency>
            <DashStyle>Solid</DashStyle>
            <Displacement>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Displacement>
            <DivideTimePrice>false</DivideTimePrice>
            <Id />
            <EndBarsAgo>0</EndBarsAgo>
            <EndY>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </EndY>
            <EntryBarsAgo>0</EntryBarsAgo>
            <EntryY>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </EntryY>
            <ExtensionBarsAgo>0</ExtensionBarsAgo>
            <ExtensionY>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </ExtensionY>
            <File />
            <ForegroundBrush xsi:type="SolidColorBrush">
              <Opacity>1</Opacity>
              <Transform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </Transform>
              <RelativeTransform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </RelativeTransform>
              <Color>
                <A>255</A>
                <R>100</R>
                <G>149</G>
                <B>237</B>
                <ScA>1</ScA>
                <ScR>0.127437681</ScR>
                <ScG>0.3005438</ScG>
                <ScB>0.8468732</ScB>
              </Color>
            </ForegroundBrush>
            <FromEntrySignal>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </FromEntrySignal>
            <IsAutoScale>false</IsAutoScale>
            <IsSimulatedStop>false</IsSimulatedStop>
            <IsStop>false</IsStop>
            <LimitPrice>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </LimitPrice>
            <LogLevel>Information</LogLevel>
            <Message>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </Message>
            <MessageValue>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </MessageValue>
            <MiddleBarsAgo>0</MiddleBarsAgo>
            <MiddleY>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </MiddleY>
            <Mode>Currency</Mode>
            <Offset>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Offset>
            <OffsetType>Currency</OffsetType>
            <Price>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Price>
            <Priority>Medium</Priority>
            <Quantity>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <DynamicValue>
                <IsExpanded>false</IsExpanded>
                <IsSelected>false</IsSelected>
                <Name>Default order quantity</Name>
                <Offset>
                  <IsSetEnabled>false</IsSetEnabled>
                  <OffsetValue>0</OffsetValue>
                  <OffsetOperator>Add</OffsetOperator>
                  <OffsetType>Arithmetic</OffsetType>
                </Offset>
                <OffsetType>Arithmetic</OffsetType>
                <AssignedCommand>
                  <Command>DefaultQuantity</Command>
                  <Parameters />
                </AssignedCommand>
                <BarsAgo>0</BarsAgo>
                <CurrencyType>Currency</CurrencyType>
                <Date>2017-10-17T06:39:21.5420464</Date>
                <DayOfWeek>Sunday</DayOfWeek>
                <EndBar>0</EndBar>
                <ForceSeriesIndex>false</ForceSeriesIndex>
                <LookBackPeriod>0</LookBackPeriod>
                <MarketPosition>Long</MarketPosition>
                <Period>0</Period>
                <ReturnType>Number</ReturnType>
                <StartBar>0</StartBar>
                <State>Undefined</State>
                <Time>0001-01-01T00:00:00</Time>
              </DynamicValue>
              <IsLiteral>false</IsLiteral>
              <LiveValue xsi:type="xsd:string">DefaultQuantity</LiveValue>
            </Quantity>
            <Ratio>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Ratio>
            <RearmSeconds>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </RearmSeconds>
            <Series>
              <AcceptableSeries>Indicator DataSeries CustomSeries DefaultSeries</AcceptableSeries>
              <CustomProperties />
              <IsExplicitlyNamed>false</IsExplicitlyNamed>
              <IsPriceTypeLocked>false</IsPriceTypeLocked>
              <PlotOnChart>false</PlotOnChart>
              <PriceType>Close</PriceType>
              <SeriesType>DefaultSeries</SeriesType>
              <NSName>Close</NSName>
            </Series>
            <ServiceName />
            <ScreenshotPath />
            <SignalName>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </SignalName>
            <SoundLocation />
            <StartBarsAgo>0</StartBarsAgo>
            <StartY>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </StartY>
            <StopPrice>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </StopPrice>
            <Subject>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </Subject>
            <Tag>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings>
                <NinjaScriptString>
                  <Index>0</Index>
                  <StringValue>Set Enter long position</StringValue>
                </NinjaScriptString>
              </Strings>
            </Tag>
            <Text>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </Text>
            <TextBarsAgo>0</TextBarsAgo>
            <TextY>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </TextY>
            <To>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </To>
            <TextPosition>BottomLeft</TextPosition>
            <Value>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Value>
            <VariableInt>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </VariableInt>
            <VariableString>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </VariableString>
            <VariableDateTime>2017-10-17T06:39:21.5420464</VariableDateTime>
            <VariableBool>false</VariableBool>
            <VariableDouble>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </VariableDouble>
            <Width>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">2</LiveValue>
            </Width>
            <Y>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Y>
          </ActionProperties>
          <ActionType>Enter</ActionType>
          <Command>
            <Command>EnterLong</Command>
            <Parameters>
              <string>quantity</string>
              <string>signalName</string>
            </Parameters>
          </Command>
        </WizardAction>
      </Actions>
      <ActiveAction>
        <IsExpanded>false</IsExpanded>
        <IsSelected>true</IsSelected>
        <Name>Enter long position</Name>
        <Offset>
          <IsSetEnabled>false</IsSetEnabled>
          <OffsetValue>0</OffsetValue>
          <OffsetOperator>Add</OffsetOperator>
          <OffsetType>Arithmetic</OffsetType>
        </Offset>
        <OffsetType>Arithmetic</OffsetType>
        <ActionProperties>
          <Anchor1BarsAgo>0</Anchor1BarsAgo>
          <Anchor1Y>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </Anchor1Y>
          <Anchor2BarsAgo>0</Anchor2BarsAgo>
          <Anchor2Y>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </Anchor2Y>
          <Anchor3BarsAgo>0</Anchor3BarsAgo>
          <Anchor3Y>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </Anchor3Y>
          <AreaBrush xsi:type="SolidColorBrush">
            <Opacity>1</Opacity>
            <Transform xsi:type="MatrixTransform">
              <Matrix>
                <M11>1</M11>
                <M12>0</M12>
                <M21>0</M21>
                <M22>1</M22>
                <OffsetX>0</OffsetX>
                <OffsetY>0</OffsetY>
              </Matrix>
            </Transform>
            <RelativeTransform xsi:type="MatrixTransform">
              <Matrix>
                <M11>1</M11>
                <M12>0</M12>
                <M21>0</M21>
                <M22>1</M22>
                <OffsetX>0</OffsetX>
                <OffsetY>0</OffsetY>
              </Matrix>
            </RelativeTransform>
            <Color>
              <A>255</A>
              <R>100</R>
              <G>149</G>
              <B>237</B>
              <ScA>1</ScA>
              <ScR>0.127437681</ScR>
              <ScG>0.3005438</ScG>
              <ScB>0.8468732</ScB>
            </Color>
          </AreaBrush>
          <AreaOpacity>
            <DefaultValue>0</DefaultValue>
            <IsInt>true</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </AreaOpacity>
          <BackBrush xsi:type="SolidColorBrush">
            <Opacity>1</Opacity>
            <Transform xsi:type="MatrixTransform">
              <Matrix>
                <M11>1</M11>
                <M12>0</M12>
                <M21>0</M21>
                <M22>1</M22>
                <OffsetX>0</OffsetX>
                <OffsetY>0</OffsetY>
              </Matrix>
            </Transform>
            <RelativeTransform xsi:type="MatrixTransform">
              <Matrix>
                <M11>1</M11>
                <M12>0</M12>
                <M21>0</M21>
                <M22>1</M22>
                <OffsetX>0</OffsetX>
                <OffsetY>0</OffsetY>
              </Matrix>
            </RelativeTransform>
            <Color>
              <A>255</A>
              <R>100</R>
              <G>149</G>
              <B>237</B>
              <ScA>1</ScA>
              <ScR>0.127437681</ScR>
              <ScG>0.3005438</ScG>
              <ScB>0.8468732</ScB>
            </Color>
          </BackBrush>
          <BarsAgo>0</BarsAgo>
          <Brush xsi:type="SolidColorBrush">
            <Opacity>1</Opacity>
            <Transform xsi:type="MatrixTransform">
              <Matrix>
                <M11>1</M11>
                <M12>0</M12>
                <M21>0</M21>
                <M22>1</M22>
                <OffsetX>0</OffsetX>
                <OffsetY>0</OffsetY>
              </Matrix>
            </Transform>
            <RelativeTransform xsi:type="MatrixTransform">
              <Matrix>
                <M11>1</M11>
                <M12>0</M12>
                <M21>0</M21>
                <M22>1</M22>
                <OffsetX>0</OffsetX>
                <OffsetY>0</OffsetY>
              </Matrix>
            </RelativeTransform>
            <Color>
              <A>255</A>
              <R>100</R>
              <G>149</G>
              <B>237</B>
              <ScA>1</ScA>
              <ScR>0.127437681</ScR>
              <ScG>0.3005438</ScG>
              <ScB>0.8468732</ScB>
            </Color>
          </Brush>
          <Color>
            <A>255</A>
            <R>100</R>
            <G>149</G>
            <B>237</B>
            <ScA>1</ScA>
            <ScR>0.127437681</ScR>
            <ScG>0.3005438</ScG>
            <ScB>0.8468732</ScB>
          </Color>
          <Currency>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </Currency>
          <DashStyle>Solid</DashStyle>
          <Displacement>
            <DefaultValue>0</DefaultValue>
            <IsInt>true</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </Displacement>
          <DivideTimePrice>false</DivideTimePrice>
          <Id />
          <EndBarsAgo>0</EndBarsAgo>
          <EndY>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </EndY>
          <EntryBarsAgo>0</EntryBarsAgo>
          <EntryY>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </EntryY>
          <ExtensionBarsAgo>0</ExtensionBarsAgo>
          <ExtensionY>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </ExtensionY>
          <File />
          <ForegroundBrush xsi:type="SolidColorBrush">
            <Opacity>1</Opacity>
            <Transform xsi:type="MatrixTransform">
              <Matrix>
                <M11>1</M11>
                <M12>0</M12>
                <M21>0</M21>
                <M22>1</M22>
                <OffsetX>0</OffsetX>
                <OffsetY>0</OffsetY>
              </Matrix>
            </Transform>
            <RelativeTransform xsi:type="MatrixTransform">
              <Matrix>
                <M11>1</M11>
                <M12>0</M12>
                <M21>0</M21>
                <M22>1</M22>
                <OffsetX>0</OffsetX>
                <OffsetY>0</OffsetY>
              </Matrix>
            </RelativeTransform>
            <Color>
              <A>255</A>
              <R>100</R>
              <G>149</G>
              <B>237</B>
              <ScA>1</ScA>
              <ScR>0.127437681</ScR>
              <ScG>0.3005438</ScG>
              <ScB>0.8468732</ScB>
            </Color>
          </ForegroundBrush>
          <FromEntrySignal>
            <SeparatorCharacter> </SeparatorCharacter>
            <Strings />
          </FromEntrySignal>
          <IsAutoScale>false</IsAutoScale>
          <IsSimulatedStop>false</IsSimulatedStop>
          <IsStop>false</IsStop>
          <LimitPrice>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </LimitPrice>
          <LogLevel>Information</LogLevel>
          <Message>
            <SeparatorCharacter> </SeparatorCharacter>
            <Strings />
          </Message>
          <MessageValue>
            <SeparatorCharacter> </SeparatorCharacter>
            <Strings />
          </MessageValue>
          <MiddleBarsAgo>0</MiddleBarsAgo>
          <MiddleY>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </MiddleY>
          <Mode>Currency</Mode>
          <Offset>
            <DefaultValue>0</DefaultValue>
            <IsInt>true</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </Offset>
          <OffsetType>Currency</OffsetType>
          <Price>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </Price>
          <Priority>Medium</Priority>
          <Quantity>
            <DefaultValue>0</DefaultValue>
            <IsInt>true</IsInt>
            <DynamicValue>
              <IsExpanded>false</IsExpanded>
              <IsSelected>false</IsSelected>
              <Name>Default order quantity</Name>
              <Offset>
                <IsSetEnabled>false</IsSetEnabled>
                <OffsetValue>0</OffsetValue>
                <OffsetOperator>Add</OffsetOperator>
                <OffsetType>Arithmetic</OffsetType>
              </Offset>
              <OffsetType>Arithmetic</OffsetType>
              <AssignedCommand>
                <Command>DefaultQuantity</Command>
                <Parameters />
              </AssignedCommand>
              <BarsAgo>0</BarsAgo>
              <CurrencyType>Currency</CurrencyType>
              <Date>2017-10-17T06:39:21.5420464</Date>
              <DayOfWeek>Sunday</DayOfWeek>
              <EndBar>0</EndBar>
              <ForceSeriesIndex>false</ForceSeriesIndex>
              <LookBackPeriod>0</LookBackPeriod>
              <MarketPosition>Long</MarketPosition>
              <Period>0</Period>
              <ReturnType>Number</ReturnType>
              <StartBar>0</StartBar>
              <State>Undefined</State>
              <Time>0001-01-01T00:00:00</Time>
            </DynamicValue>
            <IsLiteral>false</IsLiteral>
            <LiveValue xsi:type="xsd:string">DefaultQuantity</LiveValue>
          </Quantity>
          <Ratio>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </Ratio>
          <RearmSeconds>
            <DefaultValue>0</DefaultValue>
            <IsInt>true</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </RearmSeconds>
          <Series>
            <AcceptableSeries>Indicator DataSeries CustomSeries DefaultSeries</AcceptableSeries>
            <CustomProperties />
            <IsExplicitlyNamed>false</IsExplicitlyNamed>
            <IsPriceTypeLocked>false</IsPriceTypeLocked>
            <PlotOnChart>false</PlotOnChart>
            <PriceType>Close</PriceType>
            <SeriesType>DefaultSeries</SeriesType>
            <NSName>Close</NSName>
          </Series>
          <ServiceName />
          <ScreenshotPath />
          <SignalName>
            <SeparatorCharacter> </SeparatorCharacter>
            <Strings />
          </SignalName>
          <SoundLocation />
          <StartBarsAgo>0</StartBarsAgo>
          <StartY>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </StartY>
          <StopPrice>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </StopPrice>
          <Subject>
            <SeparatorCharacter> </SeparatorCharacter>
            <Strings />
          </Subject>
          <Tag>
            <SeparatorCharacter> </SeparatorCharacter>
            <Strings>
              <NinjaScriptString>
                <Index>0</Index>
                <StringValue>Set Enter long position</StringValue>
              </NinjaScriptString>
            </Strings>
          </Tag>
          <Text>
            <SeparatorCharacter> </SeparatorCharacter>
            <Strings />
          </Text>
          <TextBarsAgo>0</TextBarsAgo>
          <TextY>
            <SeparatorCharacter> </SeparatorCharacter>
            <Strings />
          </TextY>
          <To>
            <SeparatorCharacter> </SeparatorCharacter>
            <Strings />
          </To>
          <TextPosition>BottomLeft</TextPosition>
          <Value>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </Value>
          <VariableInt>
            <DefaultValue>0</DefaultValue>
            <IsInt>true</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </VariableInt>
          <VariableString>
            <SeparatorCharacter> </SeparatorCharacter>
            <Strings />
          </VariableString>
          <VariableDateTime>2017-10-17T06:39:21.5420464</VariableDateTime>
          <VariableBool>false</VariableBool>
          <VariableDouble>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </VariableDouble>
          <Width>
            <DefaultValue>0</DefaultValue>
            <IsInt>true</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">2</LiveValue>
          </Width>
          <Y>
            <DefaultValue>0</DefaultValue>
            <IsInt>false</IsInt>
            <IsLiteral>true</IsLiteral>
            <LiveValue xsi:type="xsd:string">0</LiveValue>
          </Y>
        </ActionProperties>
        <ActionType>Enter</ActionType>
        <Command>
          <Command>EnterLong</Command>
          <Parameters>
            <string>quantity</string>
            <string>signalName</string>
          </Parameters>
        </Command>
      </ActiveAction>
      <AnyOrAll>All</AnyOrAll>
      <Conditions>
        <WizardConditionGroup>
          <AnyOrAll>Any</AnyOrAll>
          <Conditions>
            <WizardCondition>
              <LeftItem xsi:type="WizardConditionItem">
                <IsExpanded>false</IsExpanded>
                <IsSelected>true</IsSelected>
                <Name>Rising</Name>
                <Offset>
                  <IsSetEnabled>false</IsSetEnabled>
                  <OffsetValue>0</OffsetValue>
                  <OffsetOperator>Add</OffsetOperator>
                  <OffsetType>Arithmetic</OffsetType>
                </Offset>
                <OffsetType>Arithmetic</OffsetType>
                <AssignedCommand>
                  <Command>IsRising({0})</Command>
                  <Parameters>
                    <string>Series1</string>
                  </Parameters>
                </AssignedCommand>
                <BarsAgo>0</BarsAgo>
                <CurrencyType>Currency</CurrencyType>
                <Date>2017-10-17T06:38:06.8096323</Date>
                <DayOfWeek>Sunday</DayOfWeek>
                <EndBar>0</EndBar>
                <ForceSeriesIndex>false</ForceSeriesIndex>
                <LookBackPeriod>0</LookBackPeriod>
                <MarketPosition>Long</MarketPosition>
                <Period>0</Period>
                <ReturnType>Bool</ReturnType>
                <Series1>
                  <AcceptableSeries>Indicator DataSeries CustomSeries DefaultSeries</AcceptableSeries>
                  <CustomProperties>
                    <item>
                      <key>
                        <string>Period</string>
                      </key>
                      <value>
                        <anyType xsi:type="NumberBuilder">
                          <LiveValue xsi:type="xsd:string">ADXPeriod</LiveValue>
                          <DefaultValue>0</DefaultValue>
                          <IsInt>true</IsInt>
                          <DynamicValue>
                            <IsExpanded>false</IsExpanded>
                            <IsSelected>true</IsSelected>
                            <Name>ADXPeriod</Name>
                            <Offset>
                              <IsSetEnabled>false</IsSetEnabled>
                              <OffsetValue>0</OffsetValue>
                              <OffsetOperator>Add</OffsetOperator>
                              <OffsetType>Arithmetic</OffsetType>
                            </Offset>
                            <OffsetType>Arithmetic</OffsetType>
                            <AssignedCommand>
                              <Command>ADXPeriod</Command>
                              <Parameters />
                            </AssignedCommand>
                            <BarsAgo>0</BarsAgo>
                            <CurrencyType>Currency</CurrencyType>
                            <Date>2017-10-17T06:38:23.2507069</Date>
                            <DayOfWeek>Sunday</DayOfWeek>
                            <EndBar>0</EndBar>
                            <ForceSeriesIndex>false</ForceSeriesIndex>
                            <LookBackPeriod>0</LookBackPeriod>
                            <MarketPosition>Long</MarketPosition>
                            <Period>0</Period>
                            <ReturnType>Number</ReturnType>
                            <StartBar>0</StartBar>
                            <State>Undefined</State>
                            <Time>0001-01-01T00:00:00</Time>
                          </DynamicValue>
                          <IsLiteral>false</IsLiteral>
                        </anyType>
                      </value>
                    </item>
                  </CustomProperties>
                  <IndicatorHolder>
                    <IndicatorName>ADX</IndicatorName>
                    <Plots>
                      <Plot>
                        <IsOpacityVisible>false</IsOpacityVisible>
                        <BrushSerialize>&lt;SolidColorBrush xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"&gt;#FF008B8B&lt;/SolidColorBrush&gt;</BrushSerialize>
                        <DashStyleHelper>Solid</DashStyleHelper>
                        <Opacity>100</Opacity>
                        <Width>1</Width>
                        <Max>1.7976931348623157E+308</Max>
                        <Min>-1.7976931348623157E+308</Min>
                        <Name>ADX</Name>
                        <PlotStyle>Line</PlotStyle>
                      </Plot>
                    </Plots>
                  </IndicatorHolder>
                  <IsExplicitlyNamed>false</IsExplicitlyNamed>
                  <IsPriceTypeLocked>false</IsPriceTypeLocked>
                  <PlotOnChart>true</PlotOnChart>
                  <PriceType>Close</PriceType>
                  <SeriesType>Indicator</SeriesType>
                  <HostedDataSeries>
                    <AcceptableSeries>Indicator DataSeries CustomSeries DefaultSeries</AcceptableSeries>
                    <CustomProperties />
                    <IsExplicitlyNamed>false</IsExplicitlyNamed>
                    <IsPriceTypeLocked>false</IsPriceTypeLocked>
                    <PlotOnChart>false</PlotOnChart>
                    <PriceType>Close</PriceType>
                    <SeriesType>DefaultSeries</SeriesType>
                    <NSName>Close</NSName>
                  </HostedDataSeries>
                  <NSName>ADX(Close, Convert.ToInt32(ADXPeriod))</NSName>
                </Series1>
                <StartBar>0</StartBar>
                <State>Undefined</State>
                <Time>0001-01-01T00:00:00</Time>
              </LeftItem>
              <Lookback>1</Lookback>
              <Operator>Equals</Operator>
              <RightItem xsi:type="WizardConditionItem">
                <IsExpanded>false</IsExpanded>
                <IsSelected>true</IsSelected>
                <Name>True</Name>
                <Offset>
                  <IsSetEnabled>false</IsSetEnabled>
                  <OffsetValue>0</OffsetValue>
                  <OffsetOperator>Add</OffsetOperator>
                  <OffsetType>Arithmetic</OffsetType>
                </Offset>
                <OffsetType>Arithmetic</OffsetType>
                <AssignedCommand>
                  <Command>true</Command>
                  <Parameters />
                </AssignedCommand>
                <BarsAgo>0</BarsAgo>
                <CurrencyType>Currency</CurrencyType>
                <Date>2017-10-17T06:38:06.8166376</Date>
                <DayOfWeek>Sunday</DayOfWeek>
                <EndBar>0</EndBar>
                <ForceSeriesIndex>false</ForceSeriesIndex>
                <LookBackPeriod>0</LookBackPeriod>
                <MarketPosition>Long</MarketPosition>
                <Period>0</Period>
                <ReturnType>Bool</ReturnType>
                <StartBar>0</StartBar>
                <State>Undefined</State>
                <Time>0001-01-01T00:00:00</Time>
              </RightItem>
            </WizardCondition>
          </Conditions>
          <IsGroup>false</IsGroup>
          <DisplayName>IsRising(ADX(Close, Convert.ToInt32(ADXPeriod))) = true</DisplayName>
        </WizardConditionGroup>
        <WizardConditionGroup>
          <AnyOrAll>Any</AnyOrAll>
          <Conditions>
            <WizardCondition>
              <LeftItem xsi:type="WizardConditionItem">
                <IsExpanded>false</IsExpanded>
                <IsSelected>true</IsSelected>
                <Name>Falling</Name>
                <Offset>
                  <IsSetEnabled>false</IsSetEnabled>
                  <OffsetValue>0</OffsetValue>
                  <OffsetOperator>Add</OffsetOperator>
                  <OffsetType>Arithmetic</OffsetType>
                </Offset>
                <OffsetType>Arithmetic</OffsetType>
                <AssignedCommand>
                  <Command>IsFalling({0})</Command>
                  <Parameters>
                    <string>Series1</string>
                  </Parameters>
                </AssignedCommand>
                <BarsAgo>0</BarsAgo>
                <CurrencyType>Currency</CurrencyType>
                <Date>2017-10-17T06:38:49.0456849</Date>
                <DayOfWeek>Sunday</DayOfWeek>
                <EndBar>0</EndBar>
                <ForceSeriesIndex>false</ForceSeriesIndex>
                <LookBackPeriod>0</LookBackPeriod>
                <MarketPosition>Long</MarketPosition>
                <Period>0</Period>
                <ReturnType>Bool</ReturnType>
                <Series1>
                  <AcceptableSeries>Indicator DataSeries CustomSeries DefaultSeries</AcceptableSeries>
                  <CustomProperties>
                    <item>
                      <key>
                        <string>Period</string>
                      </key>
                      <value>
                        <anyType xsi:type="NumberBuilder">
                          <LiveValue xsi:type="xsd:string">SMAPeriod</LiveValue>
                          <DefaultValue>0</DefaultValue>
                          <IsInt>true</IsInt>
                          <DynamicValue>
                            <IsExpanded>false</IsExpanded>
                            <IsSelected>true</IsSelected>
                            <Name>SMAPeriod</Name>
                            <Offset>
                              <IsSetEnabled>false</IsSetEnabled>
                              <OffsetValue>0</OffsetValue>
                              <OffsetOperator>Add</OffsetOperator>
                              <OffsetType>Arithmetic</OffsetType>
                            </Offset>
                            <OffsetType>Arithmetic</OffsetType>
                            <AssignedCommand>
                              <Command>SMAPeriod</Command>
                              <Parameters />
                            </AssignedCommand>
                            <BarsAgo>0</BarsAgo>
                            <CurrencyType>Currency</CurrencyType>
                            <Date>2017-10-17T06:39:04.801626</Date>
                            <DayOfWeek>Sunday</DayOfWeek>
                            <EndBar>0</EndBar>
                            <ForceSeriesIndex>false</ForceSeriesIndex>
                            <LookBackPeriod>0</LookBackPeriod>
                            <MarketPosition>Long</MarketPosition>
                            <Period>0</Period>
                            <ReturnType>Number</ReturnType>
                            <StartBar>0</StartBar>
                            <State>Undefined</State>
                            <Time>0001-01-01T00:00:00</Time>
                          </DynamicValue>
                          <IsLiteral>false</IsLiteral>
                        </anyType>
                      </value>
                    </item>
                  </CustomProperties>
                  <IndicatorHolder>
                    <IndicatorName>SMA</IndicatorName>
                    <Plots>
                      <Plot>
                        <IsOpacityVisible>false</IsOpacityVisible>
                        <BrushSerialize>&lt;SolidColorBrush xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"&gt;#FFDAA520&lt;/SolidColorBrush&gt;</BrushSerialize>
                        <DashStyleHelper>Solid</DashStyleHelper>
                        <Opacity>100</Opacity>
                        <Width>1</Width>
                        <Max>1.7976931348623157E+308</Max>
                        <Min>-1.7976931348623157E+308</Min>
                        <Name>SMA</Name>
                        <PlotStyle>Line</PlotStyle>
                      </Plot>
                    </Plots>
                  </IndicatorHolder>
                  <IsExplicitlyNamed>false</IsExplicitlyNamed>
                  <IsPriceTypeLocked>false</IsPriceTypeLocked>
                  <PlotOnChart>true</PlotOnChart>
                  <PriceType>Close</PriceType>
                  <SeriesType>Indicator</SeriesType>
                  <HostedDataSeries>
                    <AcceptableSeries>Indicator DataSeries CustomSeries DefaultSeries</AcceptableSeries>
                    <CustomProperties />
                    <IsExplicitlyNamed>false</IsExplicitlyNamed>
                    <IsPriceTypeLocked>false</IsPriceTypeLocked>
                    <PlotOnChart>false</PlotOnChart>
                    <PriceType>Close</PriceType>
                    <SeriesType>DefaultSeries</SeriesType>
                    <NSName>Close</NSName>
                  </HostedDataSeries>
                  <NSName>SMA(Close, Convert.ToInt32(SMAPeriod))</NSName>
                </Series1>
                <StartBar>0</StartBar>
                <State>Undefined</State>
                <Time>0001-01-01T00:00:00</Time>
              </LeftItem>
              <Lookback>1</Lookback>
              <Operator>Equals</Operator>
              <RightItem xsi:type="WizardConditionItem">
                <IsExpanded>false</IsExpanded>
                <IsSelected>true</IsSelected>
                <Name>True</Name>
                <Offset>
                  <IsSetEnabled>false</IsSetEnabled>
                  <OffsetValue>0</OffsetValue>
                  <OffsetOperator>Add</OffsetOperator>
                  <OffsetType>Arithmetic</OffsetType>
                </Offset>
                <OffsetType>Arithmetic</OffsetType>
                <AssignedCommand>
                  <Command>true</Command>
                  <Parameters />
                </AssignedCommand>
                <BarsAgo>0</BarsAgo>
                <CurrencyType>Currency</CurrencyType>
                <Date>2017-10-17T06:38:49.048698</Date>
                <DayOfWeek>Sunday</DayOfWeek>
                <EndBar>0</EndBar>
                <ForceSeriesIndex>false</ForceSeriesIndex>
                <LookBackPeriod>0</LookBackPeriod>
                <MarketPosition>Long</MarketPosition>
                <Period>0</Period>
                <ReturnType>Bool</ReturnType>
                <StartBar>0</StartBar>
                <State>Undefined</State>
                <Time>0001-01-01T00:00:00</Time>
              </RightItem>
            </WizardCondition>
          </Conditions>
          <IsGroup>false</IsGroup>
          <DisplayName>IsFalling(SMA(Close, Convert.ToInt32(SMAPeriod))) = true</DisplayName>
        </WizardConditionGroup>
      </Conditions>
      <SetName>Set 1</SetName>
      <SetNumber>1</SetNumber>
    </ConditionalAction>
    <ConditionalAction>
      <Actions>
        <WizardAction>
          <IsExpanded>false</IsExpanded>
          <IsSelected>true</IsSelected>
          <Name>Exit long position</Name>
          <Offset>
            <IsSetEnabled>false</IsSetEnabled>
            <OffsetValue>0</OffsetValue>
            <OffsetOperator>Add</OffsetOperator>
            <OffsetType>Arithmetic</OffsetType>
          </Offset>
          <OffsetType>Arithmetic</OffsetType>
          <ActionProperties>
            <Anchor1BarsAgo>0</Anchor1BarsAgo>
            <Anchor1Y>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Anchor1Y>
            <Anchor2BarsAgo>0</Anchor2BarsAgo>
            <Anchor2Y>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Anchor2Y>
            <Anchor3BarsAgo>0</Anchor3BarsAgo>
            <Anchor3Y>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Anchor3Y>
            <AreaBrush xsi:type="SolidColorBrush">
              <Opacity>1</Opacity>
              <Transform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </Transform>
              <RelativeTransform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </RelativeTransform>
              <Color>
                <A>255</A>
                <R>100</R>
                <G>149</G>
                <B>237</B>
                <ScA>1</ScA>
                <ScR>0.127437681</ScR>
                <ScG>0.3005438</ScG>
                <ScB>0.8468732</ScB>
              </Color>
            </AreaBrush>
            <AreaOpacity>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </AreaOpacity>
            <BackBrush xsi:type="SolidColorBrush">
              <Opacity>1</Opacity>
              <Transform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </Transform>
              <RelativeTransform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </RelativeTransform>
              <Color>
                <A>255</A>
                <R>100</R>
                <G>149</G>
                <B>237</B>
                <ScA>1</ScA>
                <ScR>0.127437681</ScR>
                <ScG>0.3005438</ScG>
                <ScB>0.8468732</ScB>
              </Color>
            </BackBrush>
            <BarsAgo>0</BarsAgo>
            <Brush xsi:type="SolidColorBrush">
              <Opacity>1</Opacity>
              <Transform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </Transform>
              <RelativeTransform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </RelativeTransform>
              <Color>
                <A>255</A>
                <R>100</R>
                <G>149</G>
                <B>237</B>
                <ScA>1</ScA>
                <ScR>0.127437681</ScR>
                <ScG>0.3005438</ScG>
                <ScB>0.8468732</ScB>
              </Color>
            </Brush>
            <Color>
              <A>255</A>
              <R>100</R>
              <G>149</G>
              <B>237</B>
              <ScA>1</ScA>
              <ScR>0.127437681</ScR>
              <ScG>0.3005438</ScG>
              <ScB>0.8468732</ScB>
            </Color>
            <Currency>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Currency>
            <DashStyle>Solid</DashStyle>
            <Displacement>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Displacement>
            <DivideTimePrice>false</DivideTimePrice>
            <Id />
            <EndBarsAgo>0</EndBarsAgo>
            <EndY>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </EndY>
            <EntryBarsAgo>0</EntryBarsAgo>
            <EntryY>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </EntryY>
            <ExtensionBarsAgo>0</ExtensionBarsAgo>
            <ExtensionY>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </ExtensionY>
            <File />
            <ForegroundBrush xsi:type="SolidColorBrush">
              <Opacity>1</Opacity>
              <Transform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </Transform>
              <RelativeTransform xsi:type="MatrixTransform">
                <Matrix>
                  <M11>1</M11>
                  <M12>0</M12>
                  <M21>0</M21>
                  <M22>1</M22>
                  <OffsetX>0</OffsetX>
                  <OffsetY>0</OffsetY>
                </Matrix>
              </RelativeTransform>
              <Color>
                <A>255</A>
                <R>100</R>
                <G>149</G>
                <B>237</B>
                <ScA>1</ScA>
                <ScR>0.127437681</ScR>
                <ScG>0.3005438</ScG>
                <ScB>0.8468732</ScB>
              </Color>
            </ForegroundBrush>
            <FromEntrySignal>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </FromEntrySignal>
            <IsAutoScale>false</IsAutoScale>
            <IsSimulatedStop>false</IsSimulatedStop>
            <IsStop>false</IsStop>
            <LimitPrice>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </LimitPrice>
            <LogLevel>Information</LogLevel>
            <Message>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </Message>
            <MessageValue>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </MessageValue>
            <MiddleBarsAgo>0</MiddleBarsAgo>
            <MiddleY>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </MiddleY>
            <Mode>Currency</Mode>
            <Offset>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Offset>
            <OffsetType>Currency</OffsetType>
            <Price>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Price>
            <Priority>Medium</Priority>
            <Quantity>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <DynamicValue>
                <IsExpanded>false</IsExpanded>
                <IsSelected>false</IsSelected>
                <Name>Default order quantity</Name>
                <Offset>
                  <IsSetEnabled>false</IsSetEnabled>
                  <OffsetValue>0</OffsetValue>
                  <OffsetOperator>Add</OffsetOperator>
                  <OffsetType>Arithmetic</OffsetType>
                </Offset>
                <OffsetType>Arithmetic</OffsetType>
                <AssignedCommand>
                  <Command>DefaultQuantity</Command>
                  <Parameters />
                </AssignedCommand>
                <BarsAgo>0</BarsAgo>
                <CurrencyType>Currency</CurrencyType>
                <Date>2017-10-17T06:40:03.425577</Date>
                <DayOfWeek>Sunday</DayOfWeek>
                <EndBar>0</EndBar>
                <ForceSeriesIndex>false</ForceSeriesIndex>
                <LookBackPeriod>0</LookBackPeriod>
                <MarketPosition>Long</MarketPosition>
                <Period>0</Period>
                <ReturnType>Number</ReturnType>
                <StartBar>0</StartBar>
                <State>Undefined</State>
                <Time>0001-01-01T00:00:00</Time>
              </DynamicValue>
              <IsLiteral>false</IsLiteral>
              <LiveValue xsi:type="xsd:string">DefaultQuantity</LiveValue>
            </Quantity>
            <Ratio>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Ratio>
            <RearmSeconds>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </RearmSeconds>
            <Series>
              <AcceptableSeries>Indicator DataSeries CustomSeries DefaultSeries</AcceptableSeries>
              <CustomProperties />
              <IsExplicitlyNamed>false</IsExplicitlyNamed>
              <IsPriceTypeLocked>false</IsPriceTypeLocked>
              <PlotOnChart>false</PlotOnChart>
              <PriceType>Close</PriceType>
              <SeriesType>DefaultSeries</SeriesType>
              <NSName>Close</NSName>
            </Series>
            <ServiceName />
            <ScreenshotPath />
            <SignalName>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </SignalName>
            <SoundLocation />
            <StartBarsAgo>0</StartBarsAgo>
            <StartY>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </StartY>
            <StopPrice>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </StopPrice>
            <Subject>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </Subject>
            <Tag>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings>
                <NinjaScriptString>
                  <Index>0</Index>
                  <StringValue>Set Exit long position</StringValue>
                </NinjaScriptString>
              </Strings>
            </Tag>
            <Text>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </Text>
            <TextBarsAgo>0</TextBarsAgo>
            <TextY>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </TextY>
            <To>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </To>
            <TextPosition>BottomLeft</TextPosition>
            <Value>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Value>
            <VariableInt>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </VariableInt>
            <VariableString>
              <SeparatorCharacter> </SeparatorCharacter>
              <Strings />
            </VariableString>
            <VariableDateTime>2017-10-17T06:40:03.425577</VariableDateTime>
            <VariableBool>false</VariableBool>
            <VariableDouble>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </VariableDouble>
            <Width>
              <DefaultValue>0</DefaultValue>
              <IsInt>true</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">2</LiveValue>
            </Width>
            <Y>
              <DefaultValue>0</DefaultValue>
              <IsInt>false</IsInt>
              <IsLiteral>true</IsLiteral>
              <LiveValue xsi:type="xsd:string">0</LiveValue>
            </Y>
          </ActionProperties>
          <ActionType>Exit</ActionType>
          <Command>
            <Command>ExitLong</Command>
            <Parameters>
              <string>quantity</string>
              <string>signalName</string>
              <string>fromEntrySignal</string>
            </Parameters>
          </Command>
        </WizardAction>
      </Actions>
      <AnyOrAll>All</AnyOrAll>
      <Conditions>
        <WizardConditionGroup>
          <AnyOrAll>Any</AnyOrAll>
          <Conditions>
            <WizardCondition>
              <LeftItem xsi:type="WizardConditionItem">
                <IsExpanded>false</IsExpanded>
                <IsSelected>true</IsSelected>
                <Name>Falling</Name>
                <Offset>
                  <IsSetEnabled>false</IsSetEnabled>
                  <OffsetValue>0</OffsetValue>
                  <OffsetOperator>Add</OffsetOperator>
                  <OffsetType>Arithmetic</OffsetType>
                </Offset>
                <OffsetType>Arithmetic</OffsetType>
                <AssignedCommand>
                  <Command>IsFalling({0})</Command>
                  <Parameters>
                    <string>Series1</string>
                  </Parameters>
                </AssignedCommand>
                <BarsAgo>0</BarsAgo>
                <CurrencyType>Currency</CurrencyType>
                <Date>2017-10-17T06:39:35.5761236</Date>
                <DayOfWeek>Sunday</DayOfWeek>
                <EndBar>0</EndBar>
                <ForceSeriesIndex>false</ForceSeriesIndex>
                <LookBackPeriod>0</LookBackPeriod>
                <MarketPosition>Long</MarketPosition>
                <Period>0</Period>
                <ReturnType>Bool</ReturnType>
                <Series1>
                  <AcceptableSeries>Indicator DataSeries CustomSeries DefaultSeries</AcceptableSeries>
                  <CustomProperties>
                    <item>
                      <key>
                        <string>Period</string>
                      </key>
                      <value>
                        <anyType xsi:type="NumberBuilder">
                          <LiveValue xsi:type="xsd:string">ADXPeriod</LiveValue>
                          <DefaultValue>0</DefaultValue>
                          <IsInt>true</IsInt>
                          <DynamicValue>
                            <IsExpanded>false</IsExpanded>
                            <IsSelected>true</IsSelected>
                            <Name>ADXPeriod</Name>
                            <Offset>
                              <IsSetEnabled>false</IsSetEnabled>
                              <OffsetValue>0</OffsetValue>
                              <OffsetOperator>Add</OffsetOperator>
                              <OffsetType>Arithmetic</OffsetType>
                            </Offset>
                            <OffsetType>Arithmetic</OffsetType>
                            <AssignedCommand>
                              <Command>ADXPeriod</Command>
                              <Parameters />
                            </AssignedCommand>
                            <BarsAgo>0</BarsAgo>
                            <CurrencyType>Currency</CurrencyType>
                            <Date>2017-10-17T06:39:45.9272292</Date>
                            <DayOfWeek>Sunday</DayOfWeek>
                            <EndBar>0</EndBar>
                            <ForceSeriesIndex>false</ForceSeriesIndex>
                            <LookBackPeriod>0</LookBackPeriod>
                            <MarketPosition>Long</MarketPosition>
                            <Period>0</Period>
                            <ReturnType>Number</ReturnType>
                            <StartBar>0</StartBar>
                            <State>Undefined</State>
                            <Time>0001-01-01T00:00:00</Time>
                          </DynamicValue>
                          <IsLiteral>false</IsLiteral>
                        </anyType>
                      </value>
                    </item>
                  </CustomProperties>
                  <IndicatorHolder>
                    <IndicatorName>ADX</IndicatorName>
                    <Plots>
                      <Plot>
                        <IsOpacityVisible>false</IsOpacityVisible>
                        <BrushSerialize>&lt;SolidColorBrush xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"&gt;#FF008B8B&lt;/SolidColorBrush&gt;</BrushSerialize>
                        <DashStyleHelper>Solid</DashStyleHelper>
                        <Opacity>100</Opacity>
                        <Width>1</Width>
                        <Max>1.7976931348623157E+308</Max>
                        <Min>-1.7976931348623157E+308</Min>
                        <Name>ADX</Name>
                        <PlotStyle>Line</PlotStyle>
                      </Plot>
                    </Plots>
                  </IndicatorHolder>
                  <IsExplicitlyNamed>false</IsExplicitlyNamed>
                  <IsPriceTypeLocked>false</IsPriceTypeLocked>
                  <PlotOnChart>false</PlotOnChart>
                  <PriceType>Close</PriceType>
                  <SeriesType>Indicator</SeriesType>
                  <HostedDataSeries>
                    <AcceptableSeries>Indicator DataSeries CustomSeries DefaultSeries</AcceptableSeries>
                    <CustomProperties />
                    <IsExplicitlyNamed>false</IsExplicitlyNamed>
                    <IsPriceTypeLocked>false</IsPriceTypeLocked>
                    <PlotOnChart>false</PlotOnChart>
                    <PriceType>Close</PriceType>
                    <SeriesType>DefaultSeries</SeriesType>
                    <NSName>Close</NSName>
                  </HostedDataSeries>
                  <NSName>ADX(Close, Convert.ToInt32(ADXPeriod))</NSName>
                </Series1>
                <StartBar>0</StartBar>
                <State>Undefined</State>
                <Time>0001-01-01T00:00:00</Time>
              </LeftItem>
              <Lookback>1</Lookback>
              <Operator>Equals</Operator>
              <RightItem xsi:type="WizardConditionItem">
                <IsExpanded>false</IsExpanded>
                <IsSelected>true</IsSelected>
                <Name>True</Name>
                <Offset>
                  <IsSetEnabled>false</IsSetEnabled>
                  <OffsetValue>0</OffsetValue>
                  <OffsetOperator>Add</OffsetOperator>
                  <OffsetType>Arithmetic</OffsetType>
                </Offset>
                <OffsetType>Arithmetic</OffsetType>
                <AssignedCommand>
                  <Command>true</Command>
                  <Parameters />
                </AssignedCommand>
                <BarsAgo>0</BarsAgo>
                <CurrencyType>Currency</CurrencyType>
                <Date>2017-10-17T06:39:35.5791316</Date>
                <DayOfWeek>Sunday</DayOfWeek>
                <EndBar>0</EndBar>
                <ForceSeriesIndex>false</ForceSeriesIndex>
                <LookBackPeriod>0</LookBackPeriod>
                <MarketPosition>Long</MarketPosition>
                <Period>0</Period>
                <ReturnType>Bool</ReturnType>
                <StartBar>0</StartBar>
                <State>Undefined</State>
                <Time>0001-01-01T00:00:00</Time>
              </RightItem>
            </WizardCondition>
          </Conditions>
          <IsGroup>false</IsGroup>
          <DisplayName>IsFalling(ADX(Close, Convert.ToInt32(ADXPeriod))) = true</DisplayName>
        </WizardConditionGroup>
      </Conditions>
      <SetName>Set 2</SetName>
      <SetNumber>2</SetNumber>
    </ConditionalAction>
  </ConditionalActions>
  <CustomSeries />
  <DataSeries />
  <Description>This sample demonstrates the use of the IsRising and IsFalling conditions within the Strategy Builder.</Description>
  <DisplayInDataBox>true</DisplayInDataBox>
  <DrawHorizontalGridLines>true</DrawHorizontalGridLines>
  <DrawOnPricePanel>true</DrawOnPricePanel>
  <DrawVerticalGridLines>true</DrawVerticalGridLines>
  <EntriesPerDirection>1</EntriesPerDirection>
  <EntryHandling>AllEntries</EntryHandling>
  <ExitOnSessionClose>true</ExitOnSessionClose>
  <ExitOnSessionCloseSeconds>30</ExitOnSessionCloseSeconds>
  <FillLimitOrdersOnTouch>false</FillLimitOrdersOnTouch>
  <InputParameters>
    <InputParameter>
      <Default>14</Default>
      <Description />
      <Name>ADXPeriod</Name>
      <Minimum>1</Minimum>
      <Type>int</Type>
    </InputParameter>
    <InputParameter>
      <Default>14</Default>
      <Description />
      <Name>SMAPeriod</Name>
      <Minimum>1</Minimum>
      <Type>int</Type>
    </InputParameter>
  </InputParameters>
  <IsTradingHoursBreakLineVisible>true</IsTradingHoursBreakLineVisible>
  <IsInstantiatedOnEachOptimizationIteration>true</IsInstantiatedOnEachOptimizationIteration>
  <MaximumBarsLookBack>TwoHundredFiftySix</MaximumBarsLookBack>
  <MinimumBarsRequired>20</MinimumBarsRequired>
  <OrderFillResolution>Standard</OrderFillResolution>
  <OrderFillResolutionValue>1</OrderFillResolutionValue>
  <OrderFillResolutionType>Minute</OrderFillResolutionType>
  <OverlayOnPrice>false</OverlayOnPrice>
  <PaintPriceMarkers>true</PaintPriceMarkers>
  <PlotParameters />
  <RealTimeErrorHandling>StopCancelClose</RealTimeErrorHandling>
  <ScaleJustification>Right</ScaleJustification>
  <ScriptType>Strategy</ScriptType>
  <Slippage>0</Slippage>
  <StartBehavior>WaitUntilFlat</StartBehavior>
  <StopsAndTargets />
  <StopTargetHandling>PerEntryExecution</StopTargetHandling>
  <TimeInForce>Gtc</TimeInForce>
  <TraceOrders>false</TraceOrders>
  <UseOnAddTradeEvent>false</UseOnAddTradeEvent>
  <UseOnAuthorizeAccountEvent>false</UseOnAuthorizeAccountEvent>
  <UseAccountItemUpdate>false</UseAccountItemUpdate>
  <UseOnCalculatePerformanceValuesEvent>true</UseOnCalculatePerformanceValuesEvent>
  <UseOnConnectionEvent>false</UseOnConnectionEvent>
  <UseOnDataPointEvent>true</UseOnDataPointEvent>
  <UseOnFundamentalDataEvent>false</UseOnFundamentalDataEvent>
  <UseOnExecutionEvent>false</UseOnExecutionEvent>
  <UseOnMouseDown>true</UseOnMouseDown>
  <UseOnMouseMove>true</UseOnMouseMove>
  <UseOnMouseUp>true</UseOnMouseUp>
  <UseOnMarketDataEvent>false</UseOnMarketDataEvent>
  <UseOnMarketDepthEvent>false</UseOnMarketDepthEvent>
  <UseOnMergePerformanceMetricEvent>false</UseOnMergePerformanceMetricEvent>
  <UseOnNextDataPointEvent>true</UseOnNextDataPointEvent>
  <UseOnNextInstrumentEvent>true</UseOnNextInstrumentEvent>
  <UseOnOptimizeEvent>true</UseOnOptimizeEvent>
  <UseOnOrderUpdateEvent>false</UseOnOrderUpdateEvent>
  <UseOnPositionUpdateEvent>false</UseOnPositionUpdateEvent>
  <UseOnRenderEvent>true</UseOnRenderEvent>
  <UseOnRestoreValuesEvent>false</UseOnRestoreValuesEvent>
  <UseOnShareEvent>true</UseOnShareEvent>
  <UseOnWindowCreatedEvent>false</UseOnWindowCreatedEvent>
  <UseOnWindowDestroyedEvent>false</UseOnWindowDestroyedEvent>
  <Variables />
  <Name>SampleIsFallingIsRising</Name>
</ScriptProperties>
@*/
#endregion
